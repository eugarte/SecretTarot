using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Core.Models;
using SecretTarot.Module.Inventory.Models;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Shipments.Models
{
    public class Shipment : EntityBase
    {
        public Shipment()
        {
            CreatedOn = DateTimeOffset.Now;
            UpdatedOn = DateTimeOffset.Now;
        }

        public long OrderId { get; set; }

        public Order Order { get; set; }

        [StringLength(450)]
        public string TrackingNumber { get; set; }

        public long WarehouseId { get; set; }

        public long? VendorId { get; set; }

        public Warehouse Warehouse { get; set; }

        public long CreatedById { get; set; }

        public User CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset UpdatedOn { get; set; }

        public IList<ShipmentItem> Items { get; set; } = new List<ShipmentItem>();
    }
}
