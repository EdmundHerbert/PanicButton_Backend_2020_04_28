using AdminPortal.HaloMysql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdminPortal.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddApplicationDataContext(this IServiceCollection services, IConfiguration configuration, string migrationAssembly)
        {
            services.AddDbContext<haloContext>(builder =>
                builder.UseMySql(configuration.GetConnectionString("DefaultConnectionMySql"),
                    options => options.MigrationsAssembly(migrationAssembly)));
            return services;
        }

    }
}
