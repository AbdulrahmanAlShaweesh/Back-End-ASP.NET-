using Microsoft.AspNetCore.Mvc;
using RouteDemo.BusinessLogic.Services.DepartmentServices;

namespace Route.Demo.Presentation.Controllers
{
    // Ask CLR to Inject an Object from IDepartmentServices : Devloped IDepartmentServices
    public class DepartmentController(IDepartmentServices departmentServices) : Controller
    {

        public IActionResult Index()
        {
            var Departments = departmentServices.GetAllDepartments();
            return View(Departments);
        }
    }
}
