using MediatR;
using SecretTarot.Module.Orders.ViewModels;

namespace SecretTarot.Module.Orders.Events
{
    public class OrderDetailGot : INotification
    {
        public OrderDetailVm OrderDetailVm { get; set; }
    }
}
