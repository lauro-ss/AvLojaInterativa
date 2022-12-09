using AvLojaInterativa.Data;
using AvLojaInterativa.Data.Interfaces;
using AvLojaInterativa.Service;
using Microsoft.EntityFrameworkCore;

namespace AvLojaInterativa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<LojaContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("LojaDatabase"))
                );

            builder.Services.AddTransient<IFabricante, FabricanteService>();
            builder.Services.AddTransient<IProduto, ProdutoService>();

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