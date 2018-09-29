using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Comments.Data
{
    public class CommentCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting("Catalog.IsCommentsRequireApproval") { Module = "Catalog", IsVisibleInCommonSettingPage = true, Value = "true" }
            );
        }
    }
}
