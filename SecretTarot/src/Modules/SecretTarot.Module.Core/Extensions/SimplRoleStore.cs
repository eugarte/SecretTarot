using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SecretTarot.Module.Core.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Extensions
{
    public class SimplRoleStore: RoleStore<Role, SimplDbContext, long, UserRole, IdentityRoleClaim<long>>
    {
        public SimplRoleStore(SimplDbContext context) : base(context)
        {
        }
    }
}
