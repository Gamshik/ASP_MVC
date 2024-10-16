using Contracts.Repositories;
using Contracts.Repositoriesz;
using DbAccess.Context;
using DbAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MVCApp.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureContext(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<LogisticContext>(
                opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("LogisticConnection"),
                db => db.MigrationsAssembly("MVCApp")));
        }
        public static void ConfigureScopedDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<ISettlementRepository, SettlementRepository>();
        }
    }
}
    