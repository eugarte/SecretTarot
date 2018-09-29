using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using SecretTarot.Infrastructure;
using SecretTarot.Module.ShippingPrices.Services;
using SecretTarot.Module.ShippingTableRate.Services;

namespace SecretTarot.Module.ShippingTableRate
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IShippingPriceServiceProvider, TableRateShippingServiceProvider>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
