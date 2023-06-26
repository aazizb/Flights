using Contracts;

using LoggerService;

namespace WebApi.Extensions
{
    public static class IServiceCollectionExtensions
    {
        private static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
        private static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
        public static void AddWebApi(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureLoggerService();
        }
    }
}

