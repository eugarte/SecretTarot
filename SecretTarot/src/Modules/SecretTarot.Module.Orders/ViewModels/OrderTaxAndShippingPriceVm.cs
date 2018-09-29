using System.Collections.Generic;
using SecretTarot.Module.ShippingPrices.Services;
using SecretTarot.Module.ShoppingCart.ViewModels;

namespace SecretTarot.Module.Orders.ViewModels
{
    public class OrderTaxAndShippingPriceVm
    {
        public bool IsProductPriceIncludedTax { get; set; }

        public IList<ShippingPrice> ShippingPrices { get; set; }

        public string SelectedShippingMethodName { get; set; }

        public CartVm Cart { get; set; }
    }
}
