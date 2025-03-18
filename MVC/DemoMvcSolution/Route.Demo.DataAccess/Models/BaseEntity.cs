using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route.Demo.DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }                // Primary key
        public int CreatedBy { get; set; }         // use Id who used to create create it 
        public DateTime CreatedOn { get; set; }
        public int LastModifedBy { get; set; }    // User Id
        public DateTime LastModifedOn { get;set; } // [Automatically Calculated ] 
        public bool IsDeleted { get; set; }      // soft deleted

    }
}
