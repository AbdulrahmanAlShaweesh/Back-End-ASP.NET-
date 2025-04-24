using Microsoft.AspNetCore.Mvc;
using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Models.Shared.Enums;
using Route.Demo.Presentation.ViewModels;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace Route.Demo.Presentation.Controllers
{
    public class EmployeeController(IEmployeeService _employeeServices, IWebHostEnvironment _environment,
            ILogger<EmployeeController> _logger) : Controller
    {

        public IActionResult Index(string? EmployeeSearchName) // we add searchname to enable use to search by name
        {
            var Employees = _employeeServices.GetAllEmployees(EmployeeSearchName);   // return Employees and then send it to the view
            return View(Employees);
        }


        #region Create Employee
        [HttpGet] // Inject Object from IDepartmentService
        public IActionResult Create(/*[FromServices]IDepartmentServices _departmentService*/) // when we get the create form view, we need to send all departments, becouse we need to display them in the form view
        {

           // ViewData["Departments"] = _departmentService.GetAllDepartments(); // all departments

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel) // will get EmployeeViewModel from Form...
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var employeeDto = new CreateEmployeeDto() {
                        Name = employeeViewModel.Name,
                        Age = employeeViewModel.Age,
                        Address = employeeViewModel.Address,
                        Email = employeeViewModel.Email,
                        EmployeeType = employeeViewModel.EmployeeType,
                        Gender = employeeViewModel.Gender,
                        HireingDate = employeeViewModel.HireingDate,
                        IsActive = employeeViewModel.IsActive,
                        PhoneNumber = employeeViewModel.PhoneNumber,
                        Salary = employeeViewModel.Salary,
                        //DepartmentId = employeeViewModel.DepartmentId, // relation
                    };

                    int Resutl = _employeeServices.CreatedEmployee(employeeDto);

                    if (Resutl > 0) return RedirectToAction(nameof(Index));
                    else ModelState.AddModelError(string.Empty, "Can not Create Employee");

                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment()) ModelState.AddModelError(string.Empty, ex.Message);
                    else _logger.LogError(ex.Message);

                }
            }
            return View(employeeViewModel);
        }
        #endregion
        
        #region Employee Detials
        [HttpGet]
        public IActionResult Detials(int? id)  // take the id from the a tag
        {
            if(!id.HasValue) return BadRequest();

            var employee = _employeeServices.GetEmployeeById(id.Value);

            return employee is not null ? View(employee) : NotFound();
            
        }
        #endregion


        #region Edit Employee
        [HttpGet]
        public IActionResult Edit(int? id)  // send the data to the view
        {
            if (!id.HasValue) return BadRequest();
            var employee = _employeeServices.GetEmployeeById(id.Value);

            if(employee is null) return NotFound();

            var employeeViewModel = new EmployeeViewModel()
            {
                 Name = employee.Name,
                Salary = employee.Salary,
                Address = employee.Address,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber, 
                IsActive = employee.IsActive,
                HireingDate = employee.HiringDate,
                Gender = Enum.Parse<Gender>(employee.Gender),
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType), 
                DepartmentId = employee.DepartmentId,
            };

            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, EmployeeViewModel employeeViewModel)
        {
            if (!id.HasValue) return BadRequest();

            if (!ModelState.IsValid) return View(employeeViewModel);
            try
            { // happy sinario

                var UpdatedEmployeeDto = new UpdatedEmployeeDto()
                {
                    Id = id.Value,
                    Name = employeeViewModel.Name,
                    Address = employeeViewModel.Address,
                    Age = employeeViewModel.Age,
                    Email   = employeeViewModel.Email,
                    EmployeeType = employeeViewModel.EmployeeType, 
                    Gender = employeeViewModel.Gender, 
                    HireingDate = employeeViewModel.HireingDate, 
                    IsActive= employeeViewModel.IsActive,
                    PhoneNumber= employeeViewModel.PhoneNumber,
                    Salary = employeeViewModel.Salary,
                    DepartmentId = employeeViewModel.DepartmentId,
                };

                var result = _employeeServices.UpdatedEmployee(UpdatedEmployeeDto);
                if(result > 0) return RedirectToAction(nameof(Index));
                else
                {
                    // adding model state {model error}
                    ModelState.AddModelError(string.Empty, "Employee is Not Found");
                    return View(employeeViewModel);
                }
            }
            catch  (Exception ex) 
            {
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(employeeViewModel);
                }else
                {
                    _logger.LogError(ex.Message);
                    return View("ErrorView", ex);
                }
            }

        }
        #endregion

     
        public IActionResult Delete(int id)
        {
            if(id == 0) return BadRequest();
            try
            {
                var Deleted = _employeeServices.DeleteEmployee(id);
                if (Deleted)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Employee Not Deleted");
                    return RedirectToAction(nameof(Delete), new {id=id});
                }
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                {
                    return RedirectToAction(nameof(Index));
                    // WIth message that employee was delated

                }
                else
                {
                    _logger.LogError(ex.Message);
                    return View("Error", ex);
                }
            }
        }
    }
}
