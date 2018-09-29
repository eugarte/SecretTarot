using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.ShoppingCart.Services;
using SecretTarot.Module.PaymentStripe.ViewModels;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Infrastructure.Helpers;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.Payments.Models;
using SecretTarot.Module.PaymentStripe.Models;

namespace SecretTarot.Module.PaymentStripe.Components
{
    public class StripeLandingViewComponent : ViewComponent
    {
        private readonly ICartService _cartService;
        private readonly IWorkContext _workContext;
        private readonly IRepositoryWithTypedId<PaymentProvider, string> _paymentProviderRepository;

        public StripeLandingViewComponent(ICartService cartService, IWorkContext workContext, IRepositoryWithTypedId<PaymentProvider, string> paymentProviderRepository)
        {
            _cartService = cartService;
            _workContext = workContext;
            _paymentProviderRepository = paymentProviderRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var stripeProvider = await _paymentProviderRepository.Query().FirstOrDefaultAsync(x => x.Id == PaymentProviderHelper.StripeProviderId);
            var stripeSetting = JsonConvert.DeserializeObject<StripeConfigForm>(stripeProvider.AdditionalSettings);
            var curentUser = await _workContext.GetCurrentUser();
            var cart = await _cartService.GetCart(curentUser.Id);
            var zeroDecimalAmount = cart.OrderTotal;
            if(!CurrencyHelper.IsZeroDecimalCurrencies())
            {
                zeroDecimalAmount = zeroDecimalAmount * 100;
            }

            var regionInfo = new RegionInfo(CultureInfo.CurrentCulture.LCID);
            var model = new StripeCheckoutForm();
            model.PublicKey = stripeSetting.PublicKey;
            model.Amount = (int)zeroDecimalAmount;
            model.ISOCurrencyCode = regionInfo.ISOCurrencySymbol;

            return View(this.GetViewPath(), model);
        }
    }
}
