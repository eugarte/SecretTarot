using System.Collections.Generic;

namespace SecretTarot.Module.ShippingPrices.Services
{
    public class GetShippingPriceResponse
    {
        public IList<ShippingPrice> ApplicablePrices = new List<ShippingPrice>();

        public string CarrierName { get; set; }

        public bool IsSuccess { get; set; }

        public string Error { get; set; }
    }
}
