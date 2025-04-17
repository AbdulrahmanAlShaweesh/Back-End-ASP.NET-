using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models.EmployeeModel;
using Route.Demo.DataAccess.Models.Shared.Enums;

namespace RouteDemo.BusinessLogic.DataTransferObject.EmployeeDto
{
    public class EmployeeDetialsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly HiringDate { get; set; }
        public string Gender { get; set; }  /// asking khalid
        public string EmployeeType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
