using BuildingBlocks.Exceptions.Handler;
using Carter;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration cfg)
        {
            services.AddCarter();

            services.AddExceptionHandler<CustomExceptionHandler>();

            services.AddHealthChecks().AddSqlServer(cfg.GetConnectionString("Database")!);

            return services;
        }

        public static WebApplication UseApiServices(this WebApplication webApplication)
        {
            webApplication.MapCarter();

            webApplication.UseExceptionHandler(opts => { });

            webApplication.UseHealthChecks("/health",
                new HealthCheckOptions
                {
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });

            return webApplication;
        }
    }
}
