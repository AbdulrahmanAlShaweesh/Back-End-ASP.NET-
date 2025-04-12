using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Models.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto
{
    public class UpdatedEmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public bool IsActive { get; set; }
        public decimal Salary { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly HireingDate { get; set; }
        public Gender Gender { get; set; }       /// Ask Khalid
        public EmployeeType EmployeeType { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public DateOnly DateOfCreation { get; set; }

    }
}
