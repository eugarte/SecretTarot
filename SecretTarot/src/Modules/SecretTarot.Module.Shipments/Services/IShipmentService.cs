using System.Collections.Generic;
using System.Threading.Tasks;
using SecretTarot.Infrastructure;
using SecretTarot.Module.Shipments.Models;

namespace SecretTarot.Module.Shipments.Services
{
    public interface IShipmentService
    {
        Task<IList<ShipmentItemVm>> GetShipmentItem(long orderId);

        Task<IList<ShipmentItemVm>> GetItemToShip(long orderId, long warehouseId);

        Task<Result> CreateShipment(Shipment shipment);
    }
}
