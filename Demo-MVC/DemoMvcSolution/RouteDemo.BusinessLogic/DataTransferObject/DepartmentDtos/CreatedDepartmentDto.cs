
namespace RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos
{
    public class CreatedDepartmentDto
    {
        [Required(ErrorMessage = "Name Field is Required")]
        public string Name { get; set; } = null!;
        
        [Required] // defualt error message
        [Range(100, int.MaxValue)]
        public string Code { get; set; } = null!;
        public DateOnly DateOfCreation { get; set; }
        public string? Description { get; set; } 
    }
}
