using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using SecretTarot.Infrastructure;
using Microsoft.AspNetCore.Identity;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Core.Models;
using SecretTarot.Module.Core.Services;

namespace SecretTarot.Module.Core
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEntityService, EntityService>();
            serviceCollection.AddTransient<IMediaService, MediaService>();
            serviceCollection.AddTransient<IThemeService, ThemeService>();
            serviceCollection.AddTransient<ITokenService, TokenService>();
            serviceCollection.AddTransient<IWidgetInstanceService, WidgetInstanceService>();
            serviceCollection.AddScoped<SignInManager<User>, SimplSignInManager<User>>();
            serviceCollection.AddScoped<IWorkContext, WorkContext>();
            serviceCollection.AddScoped<ISmsSender, SmsSender>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        }
    }
}
