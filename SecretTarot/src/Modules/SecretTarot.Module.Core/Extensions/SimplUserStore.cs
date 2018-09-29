using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SecretTarot.Module.Core.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Extensions
{
    public class SimplUserStore : UserStore<User, Role, SimplDbContext, long, IdentityUserClaim<long>, UserRole,
        IdentityUserLogin<long>,IdentityUserToken<long>, IdentityRoleClaim<long>>
    {
        public SimplUserStore(SimplDbContext context, IdentityErrorDescriber describer) : base(context, describer)
        {
        }
    }
}
