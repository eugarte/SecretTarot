using System.Linq;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.ActivityLog.Models;

namespace SecretTarot.Module.ActivityLog.Data
{
    public interface IActivityTypeRepository : IRepository<Activity>
    {
        IQueryable<MostViewEntityDto> List();
    }
}
