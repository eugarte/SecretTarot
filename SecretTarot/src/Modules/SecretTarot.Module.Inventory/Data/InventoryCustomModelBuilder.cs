using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Inventory.Models;

namespace SecretTarot.Module.Inventory.Data
{
    public class InventoryCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().HasData(new Warehouse(1) { Name = "Default warehouse", AddressId = 1 });
        }
    }
}
