using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Column("DepartmentName", TypeName = "varchar")]
        [Required]
        [MaxLength(100, ErrorMessage = "Department Name Should be less than 101 Charachters")]
        [MinLength(3, ErrorMessage = "The Department Name Should NOT Be less than 3 charachters")]
        public string? Name { get; set; }
        public int InstructorId { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
    }
}
