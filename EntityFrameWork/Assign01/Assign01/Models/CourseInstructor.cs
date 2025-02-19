using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
    [Table("CourseInstructors")]
    internal class CourseInstructor
    {
        [Key] 
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public string? Evaluate { get; set; }
    }
}
