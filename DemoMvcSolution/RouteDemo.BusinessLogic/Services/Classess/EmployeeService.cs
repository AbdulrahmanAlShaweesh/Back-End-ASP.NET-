using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace RouteDemo.BusinessLogic.Services.Classess
{
    public class EmployeeService(IEmployeeRepository _employeeRepository) : IEmployeeService
    {

        public IEnumerable<EmployeeDTo> GetAllEmployees(bool WithTracking = false)
        {
            var Employees = _employeeRepository.GetAll(WithTracking);
            
            var EmployeeDto = Employees.Select(E => new EmployeeDTo()
            {
                Id = E.Id,
                Name = E.Name,
                Age = E.Age,
                Email = E.Email,
                IsActive = E.IsActive,
                Salary = E.Salary,  
                EmployeeType = E.EmployeeType.ToString(),  // fetch from db as enum and we convert it into string
                Gender = E.Gender.ToString(), 

            });

            return EmployeeDto;
        }

        public EmployeeDetialsDto? GetEmployeeById(int id)
        {
            var Employee = _employeeRepository.GetById(id);

            if (Employee is null) return null;
            else return new EmployeeDetialsDto()
            {
                Id = Employee.Id,
                Name = Employee.Name,
                Salary = Employee.Salary,
                Address = Employee.Address,
                Age = Employee.Age,
                Email = Employee.Email,
                IsActive = Employee.IsActive,
                HiringDate = DateOnly.FromDateTime(Employee.HireDate),
            };
        }

        public int CreatedEmployee(CreateEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }

        public int DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }


        public int UpdatedEmployee(UpdatedEmployeeDto employeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
