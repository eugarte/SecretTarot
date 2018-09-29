using System.Threading.Tasks;
using SecretTarot.Module.Catalog.Models;

namespace SecretTarot.Module.Catalog.Services
{
    public interface IBrandService
    {
        Task Create(Brand brand);

        Task Update(Brand brand);

        Task Delete(long id);

        Task Delete(Brand brand);
    }
}
