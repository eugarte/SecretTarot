using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Core.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("api/entity-types")]
    public class EntityTypeApiController : Controller
    {
        private readonly IRepositoryWithTypedId<EntityType, string> _entityTypeRepository;

        public EntityTypeApiController(IRepositoryWithTypedId<EntityType, string> entityTypeRepository)
        {
            _entityTypeRepository = entityTypeRepository;
        }

        [HttpGet("menuable")]
        public IActionResult GetMenuable()
        {
            var entityTypes = _entityTypeRepository.Query()
                .Where(x => x.IsMenuable)
                .Select(x => new
                {
                    x.Id,
                    x.Name
                });

            return Ok(entityTypes);
        }
    }
}
