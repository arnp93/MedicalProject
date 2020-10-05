using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Fardin.Core.Services;
using Fardin.Core.Services.IServices;
using Fardin.DataLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fardin
{
    public class Startup
    {

        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                    options => { options.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(int));
                }); ;


            #region Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(options =>
            {
                options.LoginPath = "/adminpanel/admin/login";
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
            });
            #endregion

            #region DatabaseContext
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("dbConnection"));
            }
          );
            #endregion

            #region IoC
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<ICommentService, CommentService>();
            #endregion

            services.AddLocalization(options => options.ResourcesPath = "Resources");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();



            var supportedCultures = new List<CultureInfo>()
            {
                new CultureInfo("fa-IR"),
                new CultureInfo("en-US")
            };
            var options = new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture("fa-IR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
            };
            app.UseRequestLocalization(options);


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"

                );
                routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Not Found!!!");
            });
        }
    }
}
