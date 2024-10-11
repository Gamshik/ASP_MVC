using DbAccess.Context;
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
    }
}
