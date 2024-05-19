using DataAnnotations.Application.Interface;
using DataAnnotations.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DataAnnotations.Application
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IUserService, UserService>();
        }
    }
}
