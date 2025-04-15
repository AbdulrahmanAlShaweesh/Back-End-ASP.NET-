using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;

namespace RouteDemo.BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDTo> GetAllEmployees(bool WithTracking);
        EmployeeDetialsDto? GetEmployeeById(int id);
        int CreatedEmployee(CreateEmployeeDto employeeDto);  // return number of rows affected 
        int UpdatedEmployee(UpdatedEmployeeDto employeeDto);
        int DeleteEmployee(int id); 
    }
}
