using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Models.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Route.Demo.Presentation.ViewModels
{
    public class EmployeeViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length Should be 50 Characters")]
        [MinLength(5, ErrorMessage = "Min Length Should be 50 Characters")]
        public string Name { get; set; } = null!;
        [Range(22, 30)]
        public int? Age { get; set; }
        [RegularExpression("^[1-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}-[a-zA-Z]{5,10}$",
                            ErrorMessage = "Address must be like 123-Stree-City-Country")]  // $ end of the regualr experation
        public string? Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Hire Date")]
        public DateOnly HireingDate { get; set; }
        public Gender Gender { get; set; }
        public EmployeeType EmployeeType { get; set; }  ///// ask khalid regarding to this

        [Display(Name = "Department Name")]
 
        public int? DepartmentId { get; set; }
        public IFormFile? ProfileImage { get; set; }
    }
}
