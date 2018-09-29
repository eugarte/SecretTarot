using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.PaymentPaypalExpress.Models;
using SecretTarot.Module.PaymentPaypalExpress.ViewModels;
using SecretTarot.Module.Payments.Models;

namespace SecretTarot.Module.PaymentPaypalExpress.Components
{
    public class PaypalExpressLandingViewComponent : ViewComponent
    {
        private readonly IRepositoryWithTypedId<PaymentProvider, string> _paymentProviderRepository;

        public PaypalExpressLandingViewComponent(IRepositoryWithTypedId<PaymentProvider, string> paymentProviderRepository)
        {
            _paymentProviderRepository = paymentProviderRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var paypalExpressProvider = await _paymentProviderRepository.Query().FirstOrDefaultAsync(x => x.Id == PaymentProviderHelper.PaypalExpressProviderId);
            var paypalExpressSetting = JsonConvert.DeserializeObject<PaypalExpressConfigForm>(paypalExpressProvider.AdditionalSettings);

            var model = new PaypalExpressCheckoutForm();
            model.Environment = paypalExpressSetting.Environment;
            model.PaymentFee = paypalExpressSetting.PaymentFee;

            return View(this.GetViewPath(), model);
        }
    }
}
