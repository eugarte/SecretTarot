using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Contacts.Data
{
    public class ContactCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting("GoogleAppKey") { Module = "Contact", IsVisibleInCommonSettingPage = false, Value = "" }
            );
        }
    }
}
