using System.Threading.Tasks;
using SecretTarot.Module.Core.Models;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Orders.Services
{
    public interface IOrderEmailService
    {
        Task SendEmailToUser(User user, Order order);
    }
}
