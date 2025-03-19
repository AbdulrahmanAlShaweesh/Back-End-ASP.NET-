

using System.Reflection;
using Route.Demo.DataAccess.Data.Configurations;

namespace Route.Demo.DataAccess.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)  // Tell CLR When creating an object from ApplicationDbContext that it is depend on DbContextOption<ApplicationDbContext> option of the dbcontext
        {
            
        }

        DbSet<Department> departments { get; set; }        // Create a table for Department

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations()); // if we have view Models
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // if all configrations as on the same project
             // if models are in differante layer than configrations
             modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);  // to get the configrations for current executed project (mvc) or prsentation layer
        }

    }
}
