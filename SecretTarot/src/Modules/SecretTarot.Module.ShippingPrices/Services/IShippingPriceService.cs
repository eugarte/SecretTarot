using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecretTarot.Module.ShippingPrices.Services
{
    public interface IShippingPriceService
    {
        Task<IList<ShippingPrice>> GetApplicableShippingPrices(GetShippingPriceRequest request);
    }
}
