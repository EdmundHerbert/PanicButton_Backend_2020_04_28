using AdminPortal.Areas.Identity.Data;
using AdminPortal.Extensions;
using AdminPortal.HaloMysql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Licensing;

namespace AdminPortal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            SyncfusionLicenseProvider.RegisterLicense("MDAxQDMxMzcyZTMyMmUzMFZ4WmEyaUo5NmFJWmJ4R3hhMU9QZDlHQXAvdEE4QVVBamt6Q3lYYXJjUk09");

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddIdentity<IdentityUser, IdentityRole>()
            //    // services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<AdminPortalContext>()
            //    .AddDefaultTokenProviders();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //.AddRazorPagesOptions(options =>
            //{
            //    options.AllowAreas = true;
            //    options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
            //    options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
            //});

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.LoginPath = $"/Identity/Account/Login";
            //    options.LogoutPath = $"/Identity/Account/Logout";
            //    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            //});

            var connection = Configuration.GetConnectionString("DefaultConnectionMySql");
            //var connection = @"Server=gcapp-mysql.mysql.database.azure.com;Database=halo;port=3306;user=gcsysops@gcapp-mysql;password=9zgGEQs7b&Gm;Trusted_Connection=True;ConnectRetryCount=0";



            services.AddContexts(Configuration, "AdminPortal");

            //services.AddDbContext<haloContext>
            //(options => options.UseMySql(connection));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
