using ChatWithMe.AuthStorage;
using ChatWithMe.AuthStorage.Entities;
using ChatWithMe.Common;
using ChatWithMe.Core.Extensions;
using ChatWithMe.Storage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChatWithMe.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        protected IHostingEnvironment Env { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.Configure<AppConfig>(Configuration);

            services.AddApplicationServices(Configuration);
            services.AddDataProviders(Configuration);

            services.AddScoped<DatabaseContext>();
            services.AddDbContext<AuthContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ChatWithMe.Db")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AuthContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                // TODO: Add middleware
                //app.UseExceptionHandler("/Home/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes => routes.MapRoute(name: "default", template: "{controller=Auth}/{action=SignUp}"));
        }
    }
}
