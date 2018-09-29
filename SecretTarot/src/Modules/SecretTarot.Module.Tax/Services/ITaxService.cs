using System.Threading.Tasks;

namespace SecretTarot.Module.Tax.Services
{
    public interface ITaxService
    {
        Task<decimal> GetTaxPercent(long? taxClassId, string countryId, long stateOrProvinceId, string ZipCode);
    }
}
