using System.Threading.Tasks;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Vendors.Services
{
    public interface IVendorService
    {
        Task Create(Vendor brand);

        Task Update(Vendor brand);

        Task Delete(long id);

        Task Delete(Vendor brand);
    }
}
