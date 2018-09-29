using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.ActivityLog.Models;

namespace SecretTarot.Module.ActivityLog.Data
{
    public class ActivityLogCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasIndex(x => x.ActivityTypeId);

            modelBuilder.Entity<ActivityType>().HasData(new ActivityType(1) { Name = "EntityView" });
        }
    }
}
