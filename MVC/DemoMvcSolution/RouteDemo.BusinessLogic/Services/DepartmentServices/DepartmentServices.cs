using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models;
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;
using RouteDemo.BusinessLogic.Factories;


namespace RouteDemo.BusinessLogic.Services.DepartmentServices
{
    // we inject an object from class that inherit from IDepartmentRepository
    public class DepartmentServices(IDepartmentRepository _departmentRepository) : IDepartmentServices
    {
        // 1.0 Injection : CLR will understand that we need in inject DepartmentRepsoitoty, but it can not do it
        // we need to add services in services container in program.cs

        // Get All Departments
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            //var Departments = departmentRepository.GetAll(true); // if we need to track
            var Departments = _departmentRepository.GetAll();

            #region Manual Mapping
            //var departmentToReturns = Departments.Select(D => new DepartmentDto() // Mapping
            //{
            //    DepartmentId = D.Id,
            //    Name = D.Name,
            //    Code = D.Code,
            //    Description = D.Description,
            //    DateOfCreation = DateOnly.FromDateTime(D.CreatedOn)
            //});

            //return departmentToReturns; 
            #endregion
            #region Extention Methods
            return Departments.Select(D => D.ToDepartmentDto());
            #endregion
        }

        public DepartmentDetialsDto? GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetById(id);

            #region  Mapper
            // Mapper
            //if (department is null) return null;
            //else
            //{
            //    var departmentToReturn = new DepartmentDetialsDto()
            //    {
            //        Id = department.Id,
            //        CreatedBy = department.CreatedBy,
            //        CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
            //        LastModifedBy = department.LastModifedBy,
            //        LastModifedOn = DateOnly.FromDateTime(department.LastModifedOn),
            //        IsDeleted = department.IsDeleted,
            //        Name = department.Name,
            //        Code = department.Code,
            //        Description= department.Description,
            //    };
            //    return departmentToReturn;
            //} 
            #endregion

            // using manual mapping
            return department is null ? null : department.ToDepartmentDetialsDto(); // convert department into ToDepartmentDto Extention
            #region ManualMapping
            //return department is null ? null : new DepartmentDetialsDto()
            //{
            //    Id = department.Id,
            //    CreatedBy = department.CreatedBy,
            //    CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
            //    LastModifedBy = department.LastModifedBy,
            //    LastModifedOn = DateOnly.FromDateTime(department.LastModifedOn),
            //    IsDeleted = department.IsDeleted,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //}; 
            #endregion
        }

        // Create a new department :: will return number of rows effectated 
        public int CreateDepartment(CreatedDepartmentDto departmentDto)
        {
            var department = departmentDto.ToEntity();

            return _departmentRepository.Add(department);
        }

        // Updated Department Services
        public int UpdateDepartment(UpdatedDepartmentDto updatedDepartment)
        {
            // we can update some filed and we can not update others depended on bussiness
            // [Name, Code, Description, Date of creation]
            // EF will Update based on Department Id

            return _departmentRepository.Update(updatedDepartment.ToEntity());
        }

        // Deleted Department Services ...
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id); // get the department that has the id
            if (department is null)
            {
                return false;
            }
            else
            {
                int Result = _departmentRepository.Remove(department);  // remove department and return number of row effected

                return Result > 0 ? true : false;

            }
        }
    }
}
