using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;

namespace RouteDemo.BusinessLogic.Services.Interfaces
{
    public interface IDepartmentServices
    {
        int CreatedDepartment(CreatedDepartmentDto employeeDto);

        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetialsDto? GetDepartmentById(int id);
        int UpdateDepartment(UpdatedDepartmentDto updatedDepartment);
    }
}





