
using AutoMapper;
using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic.Services.AttachmentService;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace RouteDemo.BusinessLogic.Services.Classess
{
    // since we need to use the Automapper here, we need to ask the CLR To Inject an Object from IMapper interface
    public class EmployeeService(IUnitOfWork _unitOfWork, IMapper _mapper, IAttachmentService _attachmentService) : IEmployeeService
    {

        public IEnumerable<EmployeeDTo> GetAllEmployees(string? EmployeeSearchName, bool WithTracking = false)
        {

            //var Employees = _employeeRepository.GetAll(E => E.Name.ToLower().Contains(EmployeeSearchName.ToLower()));

            IEnumerable<Employee> employees;

            if (string.IsNullOrWhiteSpace(EmployeeSearchName)) // if  null or white space, maen he/she needs whole employees
            {
                employees = _unitOfWork.EmployeeRepository.GetAll(false);
            }

            else // seach for a spesfic employee
            {
                employees = _unitOfWork.EmployeeRepository.GetAll(E => E.Name.ToLower().Contains(EmployeeSearchName.ToLower()));
            }
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

            var EmployeeDto = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDTo>>(employees);
            return EmployeeDto;
        }

        public EmployeeDetialsDto? GetEmployeeById(int id)
        {
            var employee = _unitOfWork.EmployeeRepository.GetById(id);

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
            // Add
            // Update
            // Select 
            // remove [will exute all operation before savechanges

            // WE need to handle if use did not upload image
            if (employeeDto.ProfileImage is not null)
            {
                createdEmployeeDto.ProfileImage = _attachmentService.Upload(employeeDto.ProfileImage, "Images");
            }
            _unitOfWork.EmployeeRepository.Add(createdEmployeeDto); // return number of rows deletated
            return _unitOfWork.SaveChanges(); // then save changes
        }

        public int UpdatedEmployee(UpdatedEmployeeDto employeeDto)
        {
            var updatedEmployeeDto = _mapper.Map<UpdatedEmployeeDto, Employee>(employeeDto);

            _unitOfWork.EmployeeRepository.Update(updatedEmployeeDto);
            return _unitOfWork.SaveChanges();
        }

        public bool DeleteEmployee(int id)
        {
            // For Soft Deleate
            var employee = _unitOfWork.EmployeeRepository.GetById(id);
            if (employee is null) return false;
            else
            {
                employee.IsDeleted = true;
                _unitOfWork.EmployeeRepository.Update(employee); // save locally
                return _unitOfWork.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
