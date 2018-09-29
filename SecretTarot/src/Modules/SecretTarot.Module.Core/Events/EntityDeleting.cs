using MediatR;

namespace SecretTarot.Module.Core.Events
{
    public class EntityDeleting : INotification
    {
        public long EntityId { get; set; }
    }
}
