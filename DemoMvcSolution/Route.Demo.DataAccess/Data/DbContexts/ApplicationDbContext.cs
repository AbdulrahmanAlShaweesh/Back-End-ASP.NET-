

using System.Reflection;
using Route.Demo.DataAccess.Data.Configurations;
using Route.Demo.DataAccess.Models.DepartmentModel;

namespace Route.Demo.DataAccess.Data.DbContexts
{
    // Primary Constructor
    // Tell CLR When creating an object from ApplicationDbContext that it is depend on DbContextOption<ApplicationDbContext> option of the dbcontext
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Department> Departments { get; set; }        // Create a table for Department
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations()); // if we have view Models
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // if all configrations as on the same project
             // if models are in differante layer than configrations
             //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);  // to get the configrations for current executed project (mvc) or prsentation layer
        }
    }
}


 