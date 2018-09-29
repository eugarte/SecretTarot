using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.ShoppingCart.Services;

namespace SecretTarot.Module.ShoppingCart.Components
{
    public class CartBadgeViewComponent : ViewComponent
    {
        private ICartService _cartService;
        private IWorkContext _workContext;

        public CartBadgeViewComponent(ICartService cartService, IWorkContext workContext)
        {
            _cartService = cartService;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = await _cartService.GetCart(currentUser.Id);
            
            return View(this.GetViewPath(), cart.Items.Count);
        }
    }
}
