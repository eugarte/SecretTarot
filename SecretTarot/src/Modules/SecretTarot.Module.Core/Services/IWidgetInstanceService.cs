using System.Linq;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Services
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
