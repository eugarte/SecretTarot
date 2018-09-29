using System.Threading.Tasks;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.Core.Models;
using SecretTarot.Module.Core.Services;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Orders.Services
{
    public class OrderEmailService : IOrderEmailService
    {
        private readonly IEmailSender _emailSender;
        private readonly IRazorViewRenderer _viewRender;
        public OrderEmailService(IEmailSender emailSender, IRazorViewRenderer viewRender)
        {
            _emailSender = emailSender;
            _viewRender = viewRender;
        }

        public async Task SendEmailToUser(User user, Order order)
        {
            var emailBody = await _viewRender.RenderViewToStringAsync("/Modules/SecretTarot.Module.Orders/Views/EmailTemplates/OrderEmailToCustomer.cshtml", order);
            var emailSubject = $"Order information #{order.Id}";
            await _emailSender.SendEmailAsync(user.Email, emailSubject, emailBody, true);
        }
    }
}
