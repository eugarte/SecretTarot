using System;
using System.Linq;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Services
{
    public class WidgetInstanceService : IWidgetInstanceService
    {
        private IRepository<WidgetInstance> _widgetInstanceRepository;

        public WidgetInstanceService(IRepository<WidgetInstance> widgetInstanceRepository)
        {
            _widgetInstanceRepository = widgetInstanceRepository;
        }

        public IQueryable<WidgetInstance> GetPublished()
        {
            return _widgetInstanceRepository.Query().Where(x =>
                x.PublishStart.HasValue && x.PublishStart < DateTimeOffset.Now
                && (!x.PublishEnd.HasValue || x.PublishEnd > DateTimeOffset.Now));
        }
    }
}
