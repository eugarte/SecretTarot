﻿using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.ShippingTableRate.Models
{
    public class PriceAndDestination : EntityBase
    {
        public Country Country { get; set; }

        public string CountryId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        public long? StateOrProvinceId { get; set; }

        public District District { get; set; }

        public long? DistrictId { get; set; }

        [StringLength(450)]
        public string ZipCode { get; set; }

        public string Note { get; set; }

        public decimal MinOrderSubtotal { get; set; }

        public decimal ShippingPrice { get; set; }
    }
}
