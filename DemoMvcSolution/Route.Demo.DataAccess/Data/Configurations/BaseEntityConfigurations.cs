using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models.Shared.Classes;

namespace Route.Demo.DataAccess.Data.Configurations
{
    // used Where T : class, to tell EF that it will work only on class or any class only inherit from baseentity class or  and class that inherit from the base entity class
    class BaseEntityConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseEntity // based on who is going to inherit it
                                                                    // since the base entity is not a table, then we need to make it as a generic configuration other wise the EF will deal with it as a table
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(D => D.LastModifedOn).HasComputedColumnSql("GETDATE()");
        }
    }
}
