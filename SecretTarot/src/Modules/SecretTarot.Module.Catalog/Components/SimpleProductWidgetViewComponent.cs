using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Catalog.Services;
using SecretTarot.Module.Catalog.ViewModels;
using SecretTarot.Module.Core.Services;
using SecretTarot.Module.Core.ViewModels;

namespace SecretTarot.Module.Catalog.Components
{
    public class SimpleProductWidgetViewComponent : ViewComponent
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMediaService _mediaService;
        private readonly IProductPricingService _productPricingService;

        public SimpleProductWidgetViewComponent(IRepository<Product> productRepository, IMediaService mediaService, IProductPricingService productPricingService)
        {
            _productRepository = productRepository;
            _mediaService = mediaService;
            _productPricingService = productPricingService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new SimpleProductWidgetComponentVm
            {
                Id = widgetInstance.Id,
                WidgetName = widgetInstance.Name,
                Setting = JsonConvert.DeserializeObject<SimpleProductWidgetSetting>(widgetInstance.Data)
            };

            foreach (var item in model.Setting.Products)
            {
                var product = _productRepository.Query().Where(x => x.Id == item.Id).FirstOrDefault();

                if (product != null)
                {
                    var productThumbnail = ProductThumbnail.FromProduct(product);
                    productThumbnail.ThumbnailUrl = _mediaService.GetThumbnailUrl(product.ThumbnailImage);
                    productThumbnail.CalculatedProductPrice = _productPricingService.CalculateProductPrice(product);
                    model.Products.Add(productThumbnail);
                }
            }

            return View(this.GetViewPath(), model);
        }
    }
}
