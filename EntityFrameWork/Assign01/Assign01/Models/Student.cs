using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Student Name Must not More than 51 Charachters")]
        [MinLength(3, ErrorMessage = "Student Name Should NOT Be Less Than 3 Charachters")]
        [Required]
        public string? FName { get; set; }
        [Column("StudentLastName", TypeName = "varchar")]
        [Required]
        public string LName { get; set; } = string.Empty;
        public string? Address { get; set; }
        [Range(20 , 40)]
        public int Age { get; set; }
        public int DepId { get; set; }
    }
}
