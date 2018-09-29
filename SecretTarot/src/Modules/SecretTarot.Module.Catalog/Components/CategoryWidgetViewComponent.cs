using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Infrastructure.Web;
using SecretTarot.Module.Catalog.Models;
using SecretTarot.Module.Catalog.ViewModels;
using SecretTarot.Module.Core.Services;
using SecretTarot.Module.Core.ViewModels;

namespace SecretTarot.Module.Catalog.Components
{
    public class CategoryWidgetViewComponent : ViewComponent
    {
        private readonly IRepository<Category> _categoriesRepository;
        private readonly IMediaService _mediaService;

        public CategoryWidgetViewComponent(IRepository<Category> categoriesRepository, IMediaService mediaService)
        {
            _categoriesRepository = categoriesRepository;
            _mediaService = mediaService;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new CategoryWidgetComponentVm() {
                Id = widgetInstance.Id,
                WidgetName = widgetInstance.Name,
            };
            var settings = JsonConvert.DeserializeObject<CategoryWidgetSettings>(widgetInstance.Data);
            if (settings != null)
            {
                var category = _categoriesRepository.Query()
                    .Include(c => c.ThumbnailImage)
                    .FirstOrDefault(c => c.Id == settings.CategoryId);
                model.Category = new CategoryThumbnail() {
                    Id = category.Id,
                    Description = category.Description,
                    Name = category.Name,
                    Slug = category.Slug,
                    ThumbnailImage = category.ThumbnailImage,
                    ThumbnailUrl = _mediaService.GetThumbnailUrl(category.ThumbnailImage)
                };
            }

            return View(this.GetViewPath(), model);
        }
    }
}
