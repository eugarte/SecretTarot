using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Module.SampleData.Services;
using SecretTarot.Module.SampleData.ViewModels;

namespace SecretTarot.Module.SampleData.Controllers
{
    public class SampleDataController : Controller
    {
        private readonly ISampleDataService _sampleDataService;

        public SampleDataController(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetToSample(SampleDataOption model)
        {
            await _sampleDataService.ResetToSampleData(model);
            return Redirect("~/");
        }
    }
}
