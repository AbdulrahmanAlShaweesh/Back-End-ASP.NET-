 

namespace Route.Demo.DataAccess.Models.Shared.Classes
{
    public class BaseEntity
    {
        public int Id { get; set; }                   // Primary key
        public int CreatedBy { get; set; }           // use Id who used to create create it 
        public DateTime CreatedOn { get; set; }
        public int LastModifedBy { get; set; }      // User Id who modify the record
        public DateTime LastModifedOn { get;set; } // [Automatically Calculated ] 
        public bool IsDeleted { get; set; }        // soft deleted
    }
}
