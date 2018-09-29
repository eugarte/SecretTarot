﻿using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Catalog.Models;

namespace SecretTarot.Module.Inventory.Models
{
    public class Stock : EntityBase
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public int Quantity { get; set; }

        public int ReservedQuantity { get; set; }
    }
}
