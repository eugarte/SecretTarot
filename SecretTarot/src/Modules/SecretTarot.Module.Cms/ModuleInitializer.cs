using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SecretTarot.Infrastructure;
using SecretTarot.Module.Cms.Events;
using SecretTarot.Module.Cms.Services;
using SecretTarot.Module.Core.Events;

namespace SecretTarot.Module.Cms
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<EntityDeleting>, EntityDeletingHandler>();
            services.AddTransient<IPageService, PageService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
