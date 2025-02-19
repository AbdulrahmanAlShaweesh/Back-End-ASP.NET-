using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{
    [Table("Courses")]
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        [Column("CourseDuration")]
        public int Duration { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "The Course Name should be less than 101 Charachters")]
        [MinLength(5, ErrorMessage = "The Course Name Should NOT Be more than 5 charachters")]
        public string? Name { get; set; }
        [Column("CourseDescriptions")]
        public string? Description { get; set; }
        public int TopicId { get; set; }
    }
}
