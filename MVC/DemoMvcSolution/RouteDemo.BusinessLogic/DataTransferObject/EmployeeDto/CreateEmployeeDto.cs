using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models.EmployeeModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto
{
    public class CreateEmployeeDto
    {
        [Required(ErrorMessage = "Name Field is Required")]
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        [MaxLength(150, ErrorMessage = "Max Length is 150 Charachters")]
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public decimal Salary { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly HireingDate { get; set; }
        public EmployeeType EmployeeType { get; set; }  ///// ask khalid regarding to this
        public int CreateBy { get; set; }
        public int ModifyiedBy { get; set; }
        public DateOnly DateOfCreation { get; set; }

    }
}
