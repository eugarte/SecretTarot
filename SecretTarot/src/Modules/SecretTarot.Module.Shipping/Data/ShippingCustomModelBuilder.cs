using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Shipping.Models;

namespace SecretTarot.Module.Shipping.Data
{
    public class ShippingCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShippingProvider>().ToTable("Shipping_ShippingProvider");
        }
    }
}
