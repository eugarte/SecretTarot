using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Web;

namespace SecretTarot.Module.PaymentCoD.Components
{
    public class CoDLandingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(this.GetViewPath());
        }
    }
}
