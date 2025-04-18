 
using Route.Demo.DataAccess.Models.DepartmentModel;
using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;

namespace RouteDemo.BusinessLogic.Factories
{
    static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department department)
        {
            return new DepartmentDto()
            {
                DepartmentId = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = DateOnly.FromDateTime(department.CreatedOn)
            };
        }

        public static DepartmentDetialsDto ToDepartmentDetialsDto(this Department department)
        {
            return new DepartmentDetialsDto()
            {
                Id = department.Id,
                CreatedBy = department.CreatedBy,
                CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
                LastModifedBy = department.LastModifedBy,
                LastModifedOn = DateOnly.FromDateTime(department.LastModifedOn),
                IsDeleted = department.IsDeleted,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
            };
        }

        // return it back to its orignal [ Department ]
        public static Department ToEntity(this CreatedDepartmentDto createdDepartment) // will extention method for CreatedDepartmentDto
        {
            // return a new object from the department
            return new Department()
            {
                Name = createdDepartment.Name,
                Code = createdDepartment.Code,
                Description = createdDepartment.Description,
                CreatedOn = createdDepartment.DateOfCreation.ToDateTime(new TimeOnly()) // convert to Time Only
            };
        }
        
        // to update : using method overloading
        public static Department ToEntity(this UpdatedDepartmentDto updatedDepartment) =>  new Department()
            {
                Id = updatedDepartment.Id,
                Name = updatedDepartment.Name,
                Code = updatedDepartment.Code,
                Description = updatedDepartment.Description,
                CreatedOn = updatedDepartment.DateOfCreation.ToDateTime(new TimeOnly()),
            };


       
        
    }
}
