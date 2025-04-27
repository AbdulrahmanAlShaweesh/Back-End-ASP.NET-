 

namespace RouteDemo.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDTo> GetAllEmployees(string? EmployeeSearchName, bool WithTracking = false);
        EmployeeDetialsDto? GetEmployeeById(int id);
        int CreatedEmployee(CreateEmployeeDto employeeDto);  // return number of rows affected 
        int UpdatedEmployee(UpdatedEmployeeDto employeeDto);   
        bool DeleteEmployee(int id); 
    }
}


