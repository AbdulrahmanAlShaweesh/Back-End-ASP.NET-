using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Repositories.Classess;
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic;
using RouteDemo.BusinessLogic.Profiles;
using RouteDemo.BusinessLogic.Services.Classess;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace Route.Demo.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region  Add services to the container.
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
               
            });

            //builder.Services.AddScoped<ApplicationDbContext>(); // Registor to Serves in DJ Container
            // using AddScoped , singleto, traintion if we are working with normal server, but with DbContext we need to work with DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                // 3 ways to get anything or connection string from appsettings 
                options.UseSqlServer(builder.Configuration.GetConnectionString("defualtConnection")); // allow CLR to Create object from DbContext when needed
                options.UseLazyLoadingProxies();
            });

            //builder.Services.AddScoped<DepartmentRepository>();  // 2.0 CLR Will registor the service, when creating object from DepartmentRepository

            //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); // Tell CLR if any one need an object from IDepartmentRepository, creat an object from DepartmentRepository for Him : if we working with testing
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); // Tell CLR if any one need an object from IDepartmentRepository, creat an object from DepartmentRepository for Him  : if we working with dev, and this why we work asginst interface not concat class
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            //builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly); // Create an object from mapping profile to create the map that map between employee and employee dto 
            //                                                                 // any public class that in Business logic layer, it will get the MappingProgie and any class that inherit from it
            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfile())); // Configure action: AddProfile take profile or any object inhert from profile
            // in some case, we do want the MappingpROFILE TO Public, in this case we can create a class in Business logic layer and take it as referance assembley as below
            //builder.Services.AddAutoMapper(typeof(ProjectReferances).Assembly); // get the project assembly
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


 
