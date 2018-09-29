using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.ActivityLog.Models
{
    public class ActivityType : EntityBase
    {
        public ActivityType (long id)
        {
            Id = id;
        }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
