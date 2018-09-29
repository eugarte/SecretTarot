using System.Threading.Tasks;
using SecretTarot.Module.Catalog.Models;

namespace SecretTarot.Module.Catalog.Services
{
    public interface IProductService
    {
        void Create(Product product);

        void Update(Product product);

        Task Delete(Product product);
    }
}
