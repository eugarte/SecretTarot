using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using SecretTarot.Infrastructure;
using SecretTarot.Module.ShoppingCart.Events;
using SecretTarot.Module.Core.Events;

namespace SecretTarot.Module.Localization
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<UserSignedIn>, UserSignedInHandler>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
