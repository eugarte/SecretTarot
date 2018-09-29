using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Shipping.Models;

namespace SecretTarot.Module.ShippingTableRate.Data
{
    public class ShippingTableRateCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingProvider>().HasData(new ShippingProvider("TableRate") { Name = "Table Rate", IsEnabled = true, ConfigureUrl = "shipping-table-rate-config", ShippingPriceServiceTypeName = "SecretTarot.Module.ShippingTableRate.Services.TableRateShippingServiceProvider,SecretTarot.Module.ShippingTableRate", AdditionalSettings = null, ToAllShippingEnabledCountries = true, ToAllShippingEnabledStatesOrProvinces = true });
        }
    }
}
