using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Infrastructure.Localization;

namespace SecretTarot.Module.Localization.Data
{
    public class LocalizationCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Culture>().HasData(
               new Culture(GlobalConfiguration.DefaultCulture) { Name = "English (US)" }
            );
            modelBuilder.Entity<Culture>().ToTable("Localization_Culture");
            modelBuilder.Entity<Resource>().ToTable("Localization_Resource");
        }
    }
}
