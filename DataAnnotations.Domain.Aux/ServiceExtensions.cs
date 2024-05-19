using DataAnnotations.Domain.Aux.Interface;
using DataAnnotations.Domain.Aux.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DataAnnotations.Domain.Aux
{
    public static class ServiceExtensions
    {
        public static void ConfigureAuxApp(this IServiceCollection services)
        {
            services.AddScoped<INotification, NotificationService>();
        }
    }
}
