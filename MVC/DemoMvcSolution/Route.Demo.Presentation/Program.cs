using Microsoft.EntityFrameworkCore;
using Route.Demo.DataAccess.Data.DbContexts;

namespace Route.Demo.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region  Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddScoped<ApplicationDbContext>(); // Registor to Serves in DJ Container
            // using AddScoped , singleto, traintion if we are working with normal server, but with DbContext we need to work with DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                // 3 ways to get anything or connection string from appsettings 
                options.UseSqlServer(builder.Configuration.GetConnectionString("defualtConnection")); // allow CLR to Create object from DbContext when needed
            });


            #endregion

            var app = builder.Build();


            #region Configure the HTTP request pipeline.
            // During production
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();  // to check that all request are under protocol https (Secuore)
                                // Need to buy https ceteificate
            }

            // For devlopment
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:int?}"); 
            #endregion

            app.Run();
        }
    }
}
