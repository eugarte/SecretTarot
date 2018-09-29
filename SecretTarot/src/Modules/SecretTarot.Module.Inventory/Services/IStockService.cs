using SecretTarot.Module.Inventory.Models;
using System.Threading.Tasks;

namespace SecretTarot.Module.Inventory.Services
{
    public interface IStockService
    {
        Task AddAllProduct(Warehouse warehouse);

        Task UpdateStock(StockUpdateRequest stockUpdateRequest);
    }
}
