using Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Domain.Interfaces;
using Application.Services;
using Application.Interfaces;

namespace mvcDongHo
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
            services.AddControllersWithViews();
            services.AddDbContext<DongHoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DataConnection")));
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Admin/Login/Index";
                options.AccessDeniedPath = "";
            });

            //Login
            services.AddScoped<ITaiKhoanKHRepository, TaiKhoanKHRepository>();
            services.AddScoped<ITaiKhoanKHServices, TaiKhoanKHServices>();
            //QuanLiSanPham
            services.AddScoped<ISanPhamRepository, SanPhamRepository>();
            services.AddScoped<ISanPhamServices, SanPhamServices>();
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

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{area:exists}/{controller}/{action}/{id?}");
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "Admin",
                    defaults: new { area = "Admin", Controller = "Dashboard", Action = "Index" });
                endpoints.MapControllerRoute(
                    name: "LoginAdmin",
                    pattern: "LoginAdmin",
                    defaults: new { area = "Admin", Controller = "Login", Action = "Index" });
            });
        }
    }
}
