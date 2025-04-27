 

namespace RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos
{
    public class DepartmentDetialsDto
    {
        public int Id { get; set; }                   // Primary key
        public int CreatedBy { get; set; }           // use Id who used to create create it 
        public DateOnly CreatedOn { get; set; }
        public int LastModifedBy { get; set; }      // User Id who modify the record
        public DateOnly LastModifedOn { get; set; } // [Automatically Calculated ] 
        public bool IsDeleted { get; set; }        // soft deleted
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
