using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //services.AddSingleton<iMembersAppService, MembersAppService>();
            services.AddTransient<iMembersAppService, MembersAppService>();
            //services.AddScoped<iMembersAppService, MembersAppService>();

            services.AddTransient<iMembershipTypeAppService, MembershipTypeAppService>();




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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("defaul", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
