using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.SampleData.ViewModels;

namespace SecretTarot.Module.SampleData.Components
{
    public class SampleDataFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var sampleContentFolder = Path.Combine(GlobalConfiguration.ContentRootPath, "Modules", "SecretTarot.Module.SampleData", "SampleContent");
            var directoryInfo = new DirectoryInfo(sampleContentFolder);
            var industries = directoryInfo.GetDirectories().Select(x => x.Name).ToList();
            var model = new SampleDataOption { AvailableIndustries = industries };
            return View(this.GetViewPath(), model);
        }
    }
}
