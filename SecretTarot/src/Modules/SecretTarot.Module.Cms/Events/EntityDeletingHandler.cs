using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Cms.Models;
using SecretTarot.Module.Core.Events;

namespace SecretTarot.Module.Cms.Events
{
    public class EntityDeletingHandler : INotificationHandler<EntityDeleting>
    {
        private readonly IRepository<MenuItem> _menuItemRepository;

        public EntityDeletingHandler(IRepository<MenuItem> menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public Task Handle(EntityDeleting notification, CancellationToken cancellationToken)
        {
            var items = _menuItemRepository.Query().Where(x => x.EntityId == notification.EntityId).ToList();
            foreach(var item in items)
            {
                _menuItemRepository.Remove(item);
            }

            return Task.CompletedTask;
        }
    }
}
