using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SecretTarot.Infrastructure;
using SecretTarot.Module.ActivityLog.Data;
using SecretTarot.Module.ActivityLog.Events;
using SecretTarot.Module.Core.Events;

namespace SecretTarot.Module.ActivityLog
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IActivityTypeRepository, ActivityRepository>();
            services.AddTransient<INotificationHandler<EntityViewed>, EntityViewedHandler>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
