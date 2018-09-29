using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using MediatR;
using SecretTarot.Infrastructure;
using SecretTarot.Module.Orders.Events;
using SecretTarot.Module.Shipments.Events;
using SecretTarot.Module.Shipments.Services;

namespace SecretTarot.Module.Shipments
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<INotificationHandler<OrderDetailGot>, OrderDetailGotHandler>();
            services.AddTransient<IShipmentService, ShipmentService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
