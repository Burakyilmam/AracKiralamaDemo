using AracKiralama.Business.Abstract;
using AracKiralama.Business.Concrete;
using AracKiralama.DataAccess.Abstract;
using AracKiralama.DataAccess.Repositories;
using AracKiralama.Models;
using Microsoft.EntityFrameworkCore;

namespace AracKiralama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
            builder.Services.AddDbContext<Context>(options =>
              options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString")));
            builder.Services.AddScoped<ICarDal, CarRepository>();
            builder.Services.AddScoped<ICarService, CarManager>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}