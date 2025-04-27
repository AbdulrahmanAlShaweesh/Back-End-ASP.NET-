 
using Route.Demo.DataAccess.Models.Shared.Enums;


namespace Route.Demo.DataAccess.Data.Configurations
{
    class EmployeeConfigurations : BaseEntityConfigurations<Employee>, IEntityTypeConfiguration<Employee>
    {
        public new void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(E => E.Address).HasColumnType("varchar(150)");
            builder.Property(E => E.Salary).HasColumnType("decimal(10,3)"); 
            
            // EF will convert the gender from enum value into string, then read from db string-enum
            builder.Property(E => E.Gender).
                HasConversion((EmpGender) => EmpGender.
                ToString(), (_gender) => (Gender)Enum.Parse(typeof(Gender), _gender));

            builder.Property(E => E.EmployeeType).
                HasConversion((EmpType) => EmpType.
                    ToString(), (_Type) => (EmployeeType)Enum.
                    Parse(typeof(EmployeeType), _Type)); 
            base.Configure(builder); 
        }
    }
}


// 8, 3: revie 3, 04, 05: