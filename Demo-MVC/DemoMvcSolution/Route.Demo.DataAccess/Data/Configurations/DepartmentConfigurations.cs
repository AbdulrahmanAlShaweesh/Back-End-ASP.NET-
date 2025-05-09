﻿

using Route.Demo.DataAccess.Models.DepartmentModel;

namespace Route.Demo.DataAccess.Data.Configurations
{
    // it will inherit base entity configuration of department class
    class DepartmentConfigurations : BaseEntityConfigurations<Department>, IEntityTypeConfiguration<Department>
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name).HasColumnType("varchar(20)");
            builder.Property(D => D.Code).HasColumnType("varchar(20)");
            base.Configure(builder); // we need to do it since we inherited the baseentityconfiguration or it will not see the hide member in basentityconfigurations
            builder.HasMany(D => D.Employees).WithOne(E => E.Department).HasForeignKey(E => E.DepartmentId).OnDelete(DeleteBehavior.SetNull); // since the DepartmentId is nullable and we delete a departmeent that contains an employees it will  set the department id for that emp as null
        }
    }
}
  
 