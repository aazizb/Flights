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
        public static void AddWebApi(this IServiceCollection services)
        {
            services.ConfigureCors();
        }
    }
}

