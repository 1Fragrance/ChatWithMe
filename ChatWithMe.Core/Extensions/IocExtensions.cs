using ChatWithMe.AuthStorage;
using ChatWithMe.Core.Interfaces;
using ChatWithMe.Core.Logic.Auth;
using ChatWithMe.DataStorage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatWithMe.Core.Extensions
{
    public static class IocExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthService, AuthService>();
        }

        public static void AddDataProviders(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DataSource>();
            services.AddScoped<AuthDataSource>();
        }
    }
}
