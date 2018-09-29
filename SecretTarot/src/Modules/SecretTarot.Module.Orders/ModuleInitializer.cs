using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using SecretTarot.Infrastructure;
using SecretTarot.Module.Orders.Data;
using SecretTarot.Module.Orders.Events;
using SecretTarot.Module.Orders.Services;

namespace SecretTarot.Module.Orders
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderEmailService, OrderEmailService>();
           // services.AddSingleton<IHostedService, OrderCancellationBackgroundService>();
            services.AddTransient<INotificationHandler<OrderChanged>, OrderChangedHandler>();
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
        }
    }
}
