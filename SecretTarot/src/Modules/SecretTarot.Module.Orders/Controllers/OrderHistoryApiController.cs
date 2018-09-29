using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Orders.Controllers
{
    [Authorize(Roles = "admin, vendor")]
    public class OrderHistoryApiController : Controller
    {
        private readonly IRepository<OrderHistory> _orderHistoryRepository;

        public OrderHistoryApiController(IRepository<OrderHistory> orderHistoryRepository)
        {
            _orderHistoryRepository = orderHistoryRepository;
        }

        [HttpGet("api/orders/{orderId}/history")]
        public async Task<IActionResult> Get(long orderId)
        {
            var histories = await _orderHistoryRepository.Query()
                .Where(x => x.OrderId == orderId)
                .Select(x => new
                {
                    OldStatus = x.OldStatus.ToString(),
                    NewStatus = x.NewStatus.ToString(),
                    UserId = x.CreatedById,
                    UserFullName = x.CreatedBy.FullName,
                    x.Note,
                    x.CreatedOn
                }).ToListAsync();

            return Ok(histories);
        }
    }
}
