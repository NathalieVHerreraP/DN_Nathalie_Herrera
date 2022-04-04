using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navegation;
using GymManager.ApplicationServices.Products;
using GymManager.Core.Members;
using GymManager.Core.Products;
using GymManager.DataAccess;
using GymManager.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web
{
    public class Startup
    {

        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton((ILogger)new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File("Logtexts/logs.txt")
            .CreateLogger());

            string connectionString = Configuration.GetConnectionString("Default");


            services.AddDbContext<GymManagerContext>(options => 
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<GymManagerContext>()
            .AddUserStore<UserStore<IdentityUser, IdentityRole, GymManagerContext>>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");


            

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //Other Examples
            //services.AddSingleton<iMembersAppService, MembersAppService>();
            //services.AddScoped<iMembersAppService, MembersAppService>();

            services.AddTransient<iEquipmentTypesAppService, EquipmentTypesAppService>();
            services.AddTransient<iMembershipTypesAppService, MembershipTypesAppService>();
            services.AddTransient<iMembersAppService, MembersAppService>();

            services.AddTransient<iMenuAppService, MenuAppService>();

            services.AddTransient<IRepository<int, Member>, MembersRespository>();
            services.AddTransient<IRepository<int, EquipmentType>, Repository<int, EquipmentType>>();
            services.AddTransient<IRepository<int, MembershipType>, Repository<int, MembershipType>>();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var defaultDateCulture = "es-MX";
            var ci = new CultureInfo(defaultDateCulture);

            //Configure the Localization middleware
            app.UseRequestLocalization(new RequestLocalizationOptions 
            {

                
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo> 
                { 
                    ci, 
                },
                SupportedUICultures = new List<CultureInfo> 
                { 
                    ci, 
                }
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            



            app.UseRouting();

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("defaul", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
