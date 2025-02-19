using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
   
    internal class StudentCourse
    {
        [Key]
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        [Column("StudentGrades", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Grades { get; set; }
    }
}
