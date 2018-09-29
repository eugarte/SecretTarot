using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SecretTarot.Infrastructure;
using SecretTarot.Module.Catalog.Data;
using SecretTarot.Module.Catalog.Events;
using SecretTarot.Module.Catalog.Services;
using SecretTarot.Module.Core.Events;

namespace SecretTarot.Module.Catalog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductTemplateProductAttributeRepository, ProductTemplateProductAttributeRepository>();
            services.AddTransient<INotificationHandler<ReviewSummaryChanged>, ReviewSummaryChangedHandler>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductPricingService, ProductPricingService>();
            services.AddTransient<IProductService, ProductService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
