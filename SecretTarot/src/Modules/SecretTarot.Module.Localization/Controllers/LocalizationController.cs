using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Localization.Controllers
{
    public class LocalizationController : Controller
    {
        private readonly IRepositoryWithTypedId<User, long> _userRepository;
        private readonly IWorkContext _workContext;

        public LocalizationController(IRepositoryWithTypedId<User, long> userRepository, IWorkContext workContext)
        {
            _userRepository = userRepository;
            _workContext = workContext;
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var currentUser = _userRepository.Query()
                .Single(u => u.Email == _workContext.GetCurrentUser().Result.Email);
            currentUser.Culture = culture;
            _userRepository.SaveChanges();

            return LocalRedirect(returnUrl);
        }
    }
}
