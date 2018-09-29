using System.Collections.Generic;
using SecretTarot.Module.Shipments.Services;

namespace SecretTarot.Module.Shipments.ViewModels
{
    public class ShipmentForm
    {
        public long OrderId { get; set; }

        public long WarehouseId { get; set; }

        public string TrackingNumber { get; set; }

        public IList<ShipmentItemVm> Items { get; set; } = new List<ShipmentItemVm>();
    }
}
