using System.Threading.Tasks;
using Newtonsoft.Json;
using SecretTarot.Module.ShippingPrices.Services;
using SecretTarot.Module.ShippingFree.Models;
using SecretTarot.Module.Shipping.Models;

namespace SecretTarot.Module.ShippingFree.Services
{
    public class FreeShippingServiceProvider : IShippingPriceServiceProvider
    {
        public Task<GetShippingPriceResponse> GetShippingPrices(GetShippingPriceRequest request, ShippingProvider provider)
        {
            var response = new GetShippingPriceResponse { IsSuccess = true };

            var freeShippingSetting = JsonConvert.DeserializeObject<FreeShippingSetting>(provider.AdditionalSettings);

            if (request.OrderAmount < freeShippingSetting.MinimumOrderAmount)
            {
                return Task.FromResult(response);
            }

            response.ApplicablePrices.Add(new ShippingPrice
            {
                Name = "Free",
                Price = 0
            });

            return Task.FromResult(response);
        }
    }
}
