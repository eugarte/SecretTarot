﻿using System;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Catalog.Models;

namespace SecretTarot.Module.ShoppingCart.Models
{
    public class CartItem : EntityBase
    {
        public DateTimeOffset CreatedOn { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public long CartId { get; set; }

        public Cart Cart { get; set; }
    }
}
