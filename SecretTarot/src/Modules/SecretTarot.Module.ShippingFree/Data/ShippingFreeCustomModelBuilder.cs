using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Shipping.Models;

namespace SecretTarot.Module.ShippingFree.Data
{
    public class ShippingFreeCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingProvider>().HasData(new ShippingProvider("FreeShip") { Name = "Free Ship", IsEnabled = true, ConfigureUrl = "", ShippingPriceServiceTypeName = "SecretTarot.Module.ShippingFree.Services.FreeShippingServiceProvider,SecretTarot.Module.ShippingFree", AdditionalSettings = "{MinimumOrderAmount : 1}", ToAllShippingEnabledCountries = true, ToAllShippingEnabledStatesOrProvinces = true });
        }
    }
}
