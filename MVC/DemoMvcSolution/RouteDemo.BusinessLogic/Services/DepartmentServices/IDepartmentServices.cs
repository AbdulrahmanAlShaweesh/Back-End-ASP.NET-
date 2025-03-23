using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;

namespace RouteDemo.BusinessLogic.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        int CreateDepartment(CreatedDepartmentDto departmentDto);
        bool DeleteDepartment(int id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetialsDto? GetDepartmentById(int id);
        int UpdateDepartment(UpdatedDepartmentDto updatedDepartment);
    }
}