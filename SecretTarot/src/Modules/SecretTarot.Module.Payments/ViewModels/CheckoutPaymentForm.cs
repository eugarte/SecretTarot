using System.Collections.Generic;

namespace SecretTarot.Module.Payments.ViewModels
{
    public class CheckoutPaymentForm
    {
        public IList<PaymentProviderVm> PaymentProviders { get; set; } = new List<PaymentProviderVm>();
    }
}
