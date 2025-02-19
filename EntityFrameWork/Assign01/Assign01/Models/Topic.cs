using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01.Models
{

    internal class Topic
    {
        public int Id { get; set; }
        [Column("TopicName", TypeName = "varchar")]
        [Required]
        public string? Name { get; set; }
    }
}
