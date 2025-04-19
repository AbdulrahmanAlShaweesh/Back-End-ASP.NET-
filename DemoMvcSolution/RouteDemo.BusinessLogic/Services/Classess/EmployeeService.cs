 
using AutoMapper;
using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace RouteDemo.BusinessLogic.Services.Classess
{
    // since we need to use the Automapper here, we need to ask the CLR To Inject an Object from IMapper interface
    public class EmployeeService(IEmployeeRepository _employeeRepository, IMapper _mapper) : IEmployeeService
    {

        public IEnumerable<EmployeeDTo> GetAllEmployees(bool WithTracking = false)
        {
            var Employees = _employeeRepository.GetAll(WithTracking);

            // auto mapping : Step 01 (Sourse, Destination)
            var EmployeeDto = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTo>>(Employees);  // Map From IEnumerable<Employee> to IEnumerable<EmployeeDto>
            #region Manual Mapping
            //var EmployeeDto = Employees.Select(E => new EmployeeDTo()
            //{
            //    Id = E.Id,
            //    Name = E.Name,
            //    Age = E.Age,
            //    Email = E.Email,
            //    IsActive = E.IsActive,
            //    Salary = E.Salary,
            //    EmployeeType = E.EmployeeType.ToString(),  // fetch from db as enum and we convert it into string
            //    Gender = E.Gender.ToString(),

            //}); 
            #endregion

            return EmployeeDto;
        }

        public EmployeeDetialsDto? GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);

            return employee is null ? null : _mapper.Map<Employee, EmployeeDetialsDto>(employee); // casting
            #region Manual Mapping
            //else return new EmployeeDetialsDto()
            //{
            //    Id = Employee.Id,
            //    Name = Employee.Name,
            //    Salary = Employee.Salary,
            //    Address = Employee.Address,
            //    Age = Employee.Age,
            //    Email = Employee.Email,
            //    IsActive = Employee.IsActive,
            //    HiringDate = DateOnly.FromDateTime(Employee.HireDate),
            //}; 
            #endregion
        }

        public int CreatedEmployee(CreateEmployeeDto employeeDto)
        {
            var createdEmployeeDto = _mapper.Map<CreateEmployeeDto, Employee>(employeeDto);

            return _employeeRepository.Add(createdEmployeeDto); // return number of rows deletated
            
        }

        public int UpdatedEmployee(UpdatedEmployeeDto employeeDto)
        {
            var updatedEmployeeDto = _mapper.Map<UpdatedEmployeeDto, Employee>(employeeDto);

            return _employeeRepository.Update(updatedEmployeeDto);
        }

        public bool DeleteEmployee(int id)
        {
            // For Soft Deleate
            var employee = _employeeRepository.GetById(id);
            if (employee is null) return false;
            else
            {
               employee.IsDeleted = true;
               return _employeeRepository.Update(employee) > 0? true : false;
            }
        }
    }
}
