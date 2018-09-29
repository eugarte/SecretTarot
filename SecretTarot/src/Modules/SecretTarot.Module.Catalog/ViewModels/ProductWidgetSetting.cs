﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SecretTarot.Module.Catalog.ViewModels
{
    public class ProductWidgetSetting
    {
        public int NumberOfProducts { get; set; }

        public long? CategoryId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ProductWidgetOrderBy OrderBy { get; set; }

        public bool FeaturedOnly { get; set; }
    }
}
