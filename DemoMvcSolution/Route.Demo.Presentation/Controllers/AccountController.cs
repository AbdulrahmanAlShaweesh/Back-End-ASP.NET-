using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Models.IdentityModel;
using Route.Demo.Presentation.ViewModels;

namespace Route.Demo.Presentation.Controllers
{
    // CLR Will inject object from UserNamager of ApplicationUser
    public class AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) : Controller
    {
        #region Register
        // Register 
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var User = new ApplicationUser()
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                UserName = viewModel.UserName,
                Email = viewModel.Email,

            };
            // it also take password and the hash it
            // the creatasync also add validation to password [ character, contain upper case, contain spesical charachter, contain number] these are the 4 main validations if we need to add more or custom them then inside the program in option 
            var Result = userManager.CreateAsync(User, viewModel.Password).Result; // create a new user. (.Result to make work as sync)

            if (Result.Succeeded)
                return RedirectToAction("Login");  // return to login view
            else
            {
                // here we need to handle if there is an errir, we should check if we are in production or devlopment model as we did in employee and department controllers
                foreach (var error in Result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description); // adding error
                }

                return View(viewModel); // return to the same view with all issuess that occures when user was creating an account
            }
        }
        #endregion

        // Login
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var User = userManager.FindByEmailAsync(loginViewModel.Email).Result;

            if (User is not null)
            {
                bool Flag = userManager.CheckPasswordAsync(User, loginViewModel.Password).Result;

                if (Flag)
                {

                    var Result = signInManager.PasswordSignInAsync(User, loginViewModel.Password, loginViewModel.RememberMe, false).Result;

                    if (Result.IsNotAllowed)
                    {
                        ModelState.AddModelError(string.Empty, "Your account is Not allowed");
                    }
                    if (Result.IsLockedOut)
                    {
                        ModelState.AddModelError(string.Empty, "Your account is Locked Out");
                    }
                    if (Result.Succeeded)
                    {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }
                }

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login");

            }
            return View(loginViewModel);
        }
        // Signout
    }
}
