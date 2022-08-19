using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TiMePrototype.Application.Contracts.Persistence;
using TiMePrototype.Persistence.Repositories;

namespace TiMePrototype.Persistence;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TiMeDbContext>(options =>
        {
            options.UseSqlite(@"Data Source=C:\Temp\TiMeAppPrototype.db");
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
