 
using AutoMapper;
using Route.Demo.DataAccess.Models.EmployeeModel;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;

namespace RouteDemo.BusinessLogic.Profiles
{
    public class MappingProfile : Profile
    {
        // Step 02 for mapping
        public MappingProfile() : base()
        {
            CreateMap<Employee, EmployeeDTo>()   // since all names in both models are the same, the CLR will goes to Employee Model and Converit it into EmployeeDto model, but if we have diff names then we need to add some extra configurations
                 .ForMember(des => des.EmployeeType, option => option.MapFrom(src => src.EmployeeType))
                 .ForMember(des => des.Gender, options => options.MapFrom(src => src.Gender));
                
            CreateMap<Employee, EmployeeDetialsDto>()
                .ForMember(des => des.EmployeeType, options => options.MapFrom(src => src.EmployeeType))
                .ForMember(des => des.Gender, options => options.MapFrom(src => src.Gender))
                .ForMember(des => des.HiringDate , options => options.MapFrom(src => DateOnly.FromDateTime(src.HireDate)));

            CreateMap<CreateEmployeeDto, Employee>()   // to map CreatedEmployeeDto to Employee and from Employee To CreatedEmployeeDto
                .ForMember(des => des.HireDate, options => options.MapFrom(src => src.HireingDate.ToDateTime(TimeOnly.MinValue))); // convert dateonly into date time

            CreateMap<UpdatedEmployeeDto, Employee>()
                .ForMember(dest => dest.HireDate, options => options.MapFrom(src => src.HireingDate.ToDateTime(TimeOnly.MinValue)));    
        }
    }
}
