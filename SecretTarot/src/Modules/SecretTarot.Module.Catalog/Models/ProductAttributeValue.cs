﻿using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Catalog.Models
{
    public class ProductAttributeValue : EntityBase
    {
        public long AttributeId { get; set; }

        public ProductAttribute Attribute { get; set; }

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public string Value { get; set; }
    }
}
