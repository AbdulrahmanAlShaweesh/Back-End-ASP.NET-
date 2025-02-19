using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Bounse { get; set; }
        [Column("InstructorSalary", TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Column("StudentAddress")]
        [Required]
        public string? Address { get; set; }
        public decimal HoureRate { get; set; }
        public int DepId { get; set; }
    }
}
