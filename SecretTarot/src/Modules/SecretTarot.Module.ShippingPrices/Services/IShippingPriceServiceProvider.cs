using System.Threading.Tasks;
using SecretTarot.Module.Shipping.Models;

namespace SecretTarot.Module.ShippingPrices.Services
{
    public interface IShippingPriceServiceProvider
    {
        Task<GetShippingPriceResponse> GetShippingPrices(GetShippingPriceRequest request, ShippingProvider provider);
    }
}
