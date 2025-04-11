using ClothingStore.DataAccess.Data.DbContexts;
using ClothingStore.DataAccess.Repositories.CategoryRepository;
using ClothingStore.DataAccess.Repositories.ProductRespository;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Presentation.Layter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("defualtConnection"));
            });

            builder.Services.AddScoped<IProductRepository, ProductRepository>();   // Registor Service.
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            var app = builder.Build();
            #endregion


            #region Configure the HTTP request pipeline.
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
            #endregion

            app.Run();
        }
    }
}
