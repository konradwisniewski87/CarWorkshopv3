using CarWorkshop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CarWorkshop.Infrastructure.Seeders;

namespace CarWorkshop.Infrastructure.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("CarWorkshopConnectionStrings")));

        services.AddScoped<CarWorkshopSeeder>();
    }
}
