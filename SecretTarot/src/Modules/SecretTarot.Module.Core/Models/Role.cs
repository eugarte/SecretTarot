using Microsoft.AspNetCore.Identity;
using SecretTarot.Infrastructure.Models;
using System.Collections.Generic;

namespace SecretTarot.Module.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
