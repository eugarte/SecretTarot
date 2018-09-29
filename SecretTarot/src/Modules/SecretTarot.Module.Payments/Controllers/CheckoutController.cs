﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Orders.Services;
using SecretTarot.Module.Payments.Models;
using SecretTarot.Module.Payments.ViewModels;
using SecretTarot.Module.ShoppingCart.Models;

namespace SecretTarot.Module.Payments.Controllers
{
    [Route("checkout")]
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly IRepositoryWithTypedId<PaymentProvider, string> _paymentProviderRepository;
        private readonly IRepository<Cart> _cartRepository;
        private readonly IOrderService _orderService;
        private readonly IWorkContext _workContext;

        public CheckoutController(IRepositoryWithTypedId<PaymentProvider, string> paymentProviderRepository,
            IRepository<Cart> cartRepository,
            IOrderService orderService,
            IWorkContext workContext)
        {
            _paymentProviderRepository = paymentProviderRepository;
            _cartRepository = cartRepository;
            _orderService = orderService;
            _workContext = workContext;
        }

        [HttpGet("payment")]
        public async Task<IActionResult> Payment()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = _cartRepository.Query().FirstOrDefault(x => x.UserId == currentUser.Id && x.IsActive);
            if(cart == null)
            {
                return Redirect("~/");
            }

            var checkoutPaymentForm = new CheckoutPaymentForm();
            checkoutPaymentForm.PaymentProviders = await _paymentProviderRepository.Query()
                .Where(x => x.IsEnabled)
                .Select(x => new PaymentProviderVm
                {
                    Id = x.Id,
                    Name = x.Name,
                    LandingViewComponentName = x.LandingViewComponentName
                }).ToListAsync();

            return View(checkoutPaymentForm);
        }
    }
}
