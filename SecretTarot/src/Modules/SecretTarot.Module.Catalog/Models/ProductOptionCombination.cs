﻿using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Catalog.Models
{
    public class ProductOptionCombination : EntityBase
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long OptionId { get; set; }

        public ProductOption Option { get; set; }

        public string Value { get; set; }

        public int SortIndex { get; set; }
    }
}
