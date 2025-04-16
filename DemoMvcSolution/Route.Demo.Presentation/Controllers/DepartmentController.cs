using Microsoft.AspNetCore.Mvc;
using Route.Demo.DataAccess.Models;
using Route.Demo.Presentation.ViewModels.DepartmentViewModel;
using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;
using RouteDemo.BusinessLogic.Services.Interfaces;

namespace Route.Demo.Presentation.Controllers
{
    public class DepartmentController(IDepartmentServices _departmentServices, 
        ILogger<DepartmentController> _logger, IWebHostEnvironment _environment
        ) : Controller // we used ILogger to log the error we used in the catch based on level of departmentcontroller
    {
        [HttpGet]  // BaseUrl/department/Index
        public IActionResult Index()
        {
            var Departments = _departmentServices.GetAllDepartments(); // DTO : return view for MVC, AND Json for WebAPIs
            return View(Departments);
        }

        #region Create Department
        [HttpGet]
        public IActionResult Create() => View(); // this action called once the user cick on create new employee requiest

        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto createdDepartment)
        {
            // server side validation
            if (ModelState.IsValid)
            {  // check if the CreateDepartmentDto is valid, the validation in data annodation will display if the modelstate is not valid

                try // happy sinario
                {
                   int Result = _departmentServices.CreatedDepartment(createdDepartment);

                    if(Result > 0)
                    {
                        // better way is to redirecte to the index and do what Index action does
                        return Redirect(nameof(Index));  // if the department create, will return the index view with the data
                        // return index view with the data
                        //return View(nameof(Index), _departmentServices.GetAllDepartments());   // if the department create, will return the index view with the data
                    }
                    else
                    {
                        // if the department did not create, will return the Create view with the data
                        ModelState.AddModelError(string.Empty, "Department Can't be created"); // if the server side validation sucess but data not create we can add more validation and we can spesify more the error
                        //return View(createdDepartment);  // some time, we name the create and confirmcreate in this case we will use to pass view name View("Create")
                    }
                }
                catch (Exception ex)  // bad sinario 01
                {
                    // Log the expetion based on the enviorment
                   
                   
                    if (_environment.IsDevelopment())
                    {
                        // 1.0  Development: Log error in the console and return same view with error messages
                        // log in console screen or debuge by defualt in system namespace
                        ModelState.AddModelError(string.Empty, ex.Message); // show error message
                        //return View(createdDepartment); // return same view with the error
                    }
                    else
                    {
                        // 2.0  Deployment : Log the error in file / in table in database and then return error view
                        _logger.LogError(ex.Message);
                        //return View(createdDepartment);  // normally we return error view
                    }
                }
            }
               // bad sinario 02
            
                // if model state is not valid | defualt return
                return View(createdDepartment); // will return the error message in each span in the view
       
        }

        #endregion

        public IActionResult Details(int? id)  // we used nullable int becouse in the URL use optional ID
        {
            if (!id.HasValue)
            { // 400
                return BadRequest();    // we should return a view said to the user it is a bad request, but since we do not have this view we will return the function badrequest (invalid data OR the data is not completed)
            }
            // if it have value
            var department = _departmentServices.GetDepartmentById(id.Value); // we used value becouse it is a nullable int
                                                                              // since we handle nullable chick in if condition, other wise will give us a warrning in id.value tell us that it may contain null

            if (department is null) return NotFound();  // in relaite we are surse that the department will not be null, but in case we fetch from json or anyother sourse may contain null id and that is why we check for it first
            // if everything went right, will return Detials view with department data (rendered)
            return View(department);
        }
        //[HttpPost]

        #region Edit Department
        [HttpGet]   // this action will return the view
        public IActionResult Edit(int? id)
        {

            if (!id.HasValue) return BadRequest();

            var department = _departmentServices.GetDepartmentById(id.Value);

            if (department is null) return NotFound();

            // manual mapping
            var DepartmentViewModel = new DepartmentEditViewModel()    
            {
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = department.CreatedOn
            };

            return View(DepartmentViewModel);

        }

        [HttpPost] // THIS ACTION EDIT THE VIEW
        public IActionResult Edit([FromRoute]int id, DepartmentEditViewModel viewModel) { // will take the id of the binding model form the route

            if (ModelState.IsValid)
            {
                // it may case database error, we use try and catch
                try
                {

                    var UpdatedDepartment = new UpdatedDepartmentDto()
                    {
                        Id = id,
                        Name = viewModel.Name,
                        Code = viewModel.Code,
                        Description = viewModel.Description,
                        DateOfCreation = viewModel.DateOfCreation,
                    };

                    int Resutl = _departmentServices.UpdateDepartment(UpdatedDepartment);
                    if (Resutl > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else // if department not updated
                    {
                        ModelState.AddModelError(string.Empty, "Department Did not updated");
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        // 1.0  Development: Log error in the console and return same view with error messages
                        // log in console screen or debuge by defualt in system namespace
                        ModelState.AddModelError(string.Empty, ex.Message); // show error message
                                                                            //return View(createdDepartment); // return same view with the error
                     }
                    else
                    {
                        // 2.0  Deployment : Log the error in file / in table in database and then return error view
                        _logger.LogError(ex.Message);
                        //return View(createdDepartment);  // normally we return error view
                        return View("ErrorView", ex);   // based on the error will return view or message
                    }
                }
            }

            return View(viewModel);

        }


        #endregion

        #region Delete Department
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var Department = _departmentServices.GetDepartmentById(id.Value);
            if (Department is null) return NotFound();
            return View(Department);
        }

        // this action for comirmation on the delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if(id == 0) return BadRequest();
            try
            {
               bool Deleted = _departmentServices.DeleteDepartment(id);

                if (Deleted)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Department did not deleted");
                    return RedirectToAction(nameof(Delete), new {id}); // redirectToAction will return to get action and we need to pass the model id with it (from route)
                                                                            // Only form return or redirectot post action
                }
            }
            catch (Exception ex)
            {
                // Log the expetion based on the enviorment


                if (_environment.IsDevelopment())
                {
                    // 1.0  Development: Log error in the console and return same view with error messages
                    // log in console screen or debuge by defualt in system namespace
                    ModelState.AddModelError(string.Empty, ex.Message); // show error message
                                                                        //return View(createdDepartment); // return same view with the error
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    // 2.0  Deployment : Log the error in file / in table in database and then return error view
                    _logger.LogError(ex.Message);
                    //return View(createdDepartment);  // normally we return error view
                    return View("ErrorView", ex);
                }
            }
        }
        #endregion

    }
}
