using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/roles")]
    public class RoleApiController : Controller
    {
        private readonly IRepository<Role> _roleRepository;

        public RoleApiController(IRepository<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IActionResult> Get()
        {
            var roles = await _roleRepository.Query().Select(x => new
            {
                x.Id,
                x.Name
            }).ToListAsync();

            return Json(roles);
        }
    }
}
