using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using SecretTarot.Infrastructure;
using SecretTarot.Module.ActivityLog.Events;
using SecretTarot.Module.Core.Events;
using SecretTarot.Module.ProductRecentlyViewed.Data;

namespace SecretTarot.Module.ProductRecentlyViewed
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRecentlyViewedProductRepository, RecentlyViewedProductRepository>();
            services.AddTransient<INotificationHandler<EntityViewed>, EntityViewedHandler>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
