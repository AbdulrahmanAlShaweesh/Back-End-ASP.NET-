

using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Route.Demo.DataAccess.Models.DepartmentModel;
using Route.Demo.DataAccess.Models.IdentityModel;

namespace Route.Demo.DataAccess.Data.DbContexts
{
    // Primary Constructor
    // Tell CLR When creating an object from ApplicationDbContext that it is depend on DbContextOption<ApplicationDbContext> option of the dbcontext
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations()); // if we have view Models
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // if all configrations as on the same project
                                                                                           // if models are in differante layer than configrations
                                                                                           //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);  // to get the configrations for current executed project (mvc) or prsentation layer
            base.OnModelCreating(modelBuilder); // to keep the configuration that on OnModelCreating and we need to add any custom configurations we add them after this line
        }
    }
}


