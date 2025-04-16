using Microsoft.AspNetCore.Mvc;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace Route.Demo.Presentation.Controllers
{
    public class EmployeeController(IEmployeeService _employeeServices) : Controller
    {

        public IActionResult Index()
        {
            var Employees = _employeeServices.GetAllEmployees();   // return Employees and then send it to the view
            return View(Employees);
        }
    }
}
