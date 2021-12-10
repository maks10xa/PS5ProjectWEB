using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WinFormsPS5Project.BuisenessLogicLayer.Services;
using WinFormsPS5Project.BuisenessLogicLayer.Services.Interfaces;
using WinFormsPS5Project.DataAccessLayer.Models;
using WinFormsPS5Project.DataAccessLayer.Repositories;
using WinFormsPS5Project.DataAccessLayer.Repositories.Interfaces;

namespace PS5Proj.WEB_MVC
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
            Configuration.Bind("Project", new Config());

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PS5ProjContext>(options => options.UseSqlServer(connection));

            services.AddControllersWithViews();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<ICostsService, CostsService>();
            services.AddScoped<IContactService, ContactService>();

            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IGameRepo, GameRepo>();
            services.AddScoped<ICostRepo, CostRepo>();
            services.AddScoped<IContactRepo, ContactRepo>();
            

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            //{
            //    opts.User.RequireUniqueEmail = true;
            //    opts.Password.RequiredLength = 6;
            //    opts.Password.RequireNonAlphanumeric = false;
            //    opts.Password.RequireUppercase = false;
            //    opts.Password.RequireLowercase = false;
            //    opts.Password.RequireDigit = false;
            //}).AddDefaultTokenProviders();

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.Cookie.Name = "myCompanyAuth";
            //    options.Cookie.HttpOnly = true;
            //    options.LoginPath = "/account/login";
            //    options.AccessDeniedPath = "/account/accessdenied";
            //    options.SlidingExpiration = true;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Main}/{action=Index}/{id?}");
            });
        }
    }
}
