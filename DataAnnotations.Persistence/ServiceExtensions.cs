using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DataAnnotations.Domain.Interface;
using DataAnnotations.Persistence.Repository;
using DataAnnotations.Persistence.Context;

namespace DataAnnotations.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                   IConfiguration configuration)
        {

            services.AddDbContext<AppDbContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
