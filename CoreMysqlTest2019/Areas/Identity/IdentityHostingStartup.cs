using AdminPortal.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AdminPortal.Areas.Identity.IdentityHostingStartup))]
namespace AdminPortal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AdminPortalContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdminPortalContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<AdminPortalContext>();
            });
        }
    }
}