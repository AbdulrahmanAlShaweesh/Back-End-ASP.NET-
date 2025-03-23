using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos
{
    public class UpdatedDepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // due to Name filed does not allow null in db and in update may change may not
        public string Code { get; set; } = string.Empty;
        public DateOnly DateOfCreation { get; set; }
        public string Description { get; set; }
    }
}
