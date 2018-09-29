using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.ProductRecentlyViewed.ViewModels;
using SecretTarot.Module.Core.Services;
using SecretTarot.Module.Core.ViewModels;

namespace SecretTarot.Module.ProductRecentlyViewed.Components
{
    public class RecentlyViewedWidgetViewComponent: ViewComponent
    {
        private IMediaService _mediaService;

        public RecentlyViewedWidgetViewComponent(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new RecentlyViewedWidgetViewComponentVm
            {
                Id = widgetInstance.Id,
                ItemCount = JsonConvert.DeserializeObject<int>(widgetInstance.Data)
            };

            return View(this.GetViewPath(), model);
        }

    }
}
