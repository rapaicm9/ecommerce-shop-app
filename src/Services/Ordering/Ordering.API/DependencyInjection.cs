namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            // TODO: Add services related to Carter and other API related libraries

            return services;
        }

        public static WebApplication UseApiServices(this WebApplication webApplication)
        {
            // TODO: Lifecycle goes here

            return webApplication;
        }
    }
}
