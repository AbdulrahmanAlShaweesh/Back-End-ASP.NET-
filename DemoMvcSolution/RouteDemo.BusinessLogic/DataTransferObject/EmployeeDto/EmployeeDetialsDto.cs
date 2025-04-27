

using Microsoft.AspNetCore.Http;

namespace RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto
{
    public class EmployeeDetialsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Hiring Date")]
        public DateOnly HiringDate { get; set; }
        public string Gender { get; set; } = null!; /// asking khalid
        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; } = null!;
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Last Modified By")]
        public int LastModifedBy { get; set; }
        [Display(Name = "Last Modified On")]
        public DateTime LastModifiedOn { get; set; }
        [Display(Name = "Department Id")]
        public int? DepartmentId { get; set; }
        [Display(Name = "Department Name")]
        public string? Department { get; set; }  // lazy loading department
        public string? ProfileImage { get; set; }
    }
}


 