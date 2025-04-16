using Microsoft.AspNetCore.Mvc;
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


    }
}
