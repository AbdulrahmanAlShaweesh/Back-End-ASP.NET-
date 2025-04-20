using Microsoft.AspNetCore.Mvc;
using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Models.Shared.Enums;
using RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace Route.Demo.Presentation.Controllers
{
    public class EmployeeController(IEmployeeService _employeeServices, IWebHostEnvironment _environment,
            ILogger<EmployeeController> _logger) : Controller
    {

        public IActionResult Index()
        {
            var Employees = _employeeServices.GetAllEmployees();   // return Employees and then send it to the view
            return View(Employees);
        }


        #region Create Employee
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
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
            return View(employeeDto);
        }
        #endregion

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        #region Employee Detials
        [HttpGet]
        public IActionResult Detials(int? id)  // take the id from the a tag
        {
            if(!id.HasValue) return BadRequest();

            var employee = _employeeServices.GetEmployeeById(id.Value);

            return employee is null ? NotFound() : View(employee);
            
        }
        #endregion










        #region Edit Employee
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var employee = _employeeServices.GetEmployeeById(id.Value);

            if(employee is null) return NotFound();

            var employeeDto = new UpdatedEmployeeDto()
            {
                Id = employee.Id,
                Name = employee.Name,
                Salary = employee.Salary,
                Address = employee.Address,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber, 
                IsActive = employee.IsActive,
                HireingDate = employee.HiringDate,
                Gender = Enum.Parse<Gender>(employee.Gender),
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType)
            };

            return View(employeeDto);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, UpdatedEmployeeDto employeeDto)
        {
            if (!id.HasValue || id != employeeDto.Id) return BadRequest();

            if (!ModelState.IsValid) return View(employeeDto);
            try
            { // happy sinario
                var result = _employeeServices.UpdatedEmployee(employeeDto);
                if(result > 0) return RedirectToAction(nameof(Index));
                else
                {
                    // adding model state {model error}
                    ModelState.AddModelError(string.Empty, "Employee is Not Found");
                    return View(employeeDto);
                }
            }
            catch  (Exception ex) 
            {
                if (_environment.IsDevelopment())
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(employeeDto);
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
