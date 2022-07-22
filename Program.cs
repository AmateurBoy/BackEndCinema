using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndKino.Entitys;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BackEndKino.DB.DAO;
using System.Runtime.Intrinsics.X86;

namespace BackEndKino
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
           
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Values}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.Run();

           // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
