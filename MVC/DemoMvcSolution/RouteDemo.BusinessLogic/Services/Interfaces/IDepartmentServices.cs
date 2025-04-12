using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;

namespace RouteDemo.BusinessLogic.Services.Interfaces
{
    public interface IDepartmentServices
    {
        int CreateEmployee(CreateEmployeeDto employeeDto);

        //bool DeleteDepartment(int id);
        //IEnumerable<DepartmentDto> GetAllDepartments();
        EmployeeDetialsDto? GetDepartmentById(int id);
        int UpdateDepartment(UpdatedEmployeeDto updatedDepartment);
    }
}





