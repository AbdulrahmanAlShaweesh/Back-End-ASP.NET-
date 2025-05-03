using System.ComponentModel.DataAnnotations;

namespace Route.Demo.Presentation.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First Name is Required")]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = null!;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]  // to compare between password and comirmpassword
        public string ConfirmPassword { get; set; } = null!;
        public bool IsAgree { get; set; } 
    }
}
