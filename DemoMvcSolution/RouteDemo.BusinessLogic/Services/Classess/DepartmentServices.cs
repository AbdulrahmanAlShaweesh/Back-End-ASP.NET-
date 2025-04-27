 
using Route.Demo.DataAccess.Repositories.Interfaces;
using RouteDemo.BusinessLogic.DataTransferObject.DepartmentDtos;
using RouteDemo.BusinessLogic.Factories;
using RouteDemo.BusinessLogic.Services.Interfaces;


namespace RouteDemo.BusinessLogic.Services.Classess
{
    // we work with IDepartmentRepository From UoW
    public class DepartmentServices(IUnitOfWork _unitOfWork) : IDepartmentServices
    {
        

        // Get All Departments
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            
            var Departments = _unitOfWork.DepartmentRepository.GetAll(false);

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
            var department = _unitOfWork.DepartmentRepository.GetById(id);

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
        public int CreatedDepartment(CreatedDepartmentDto departmentDto)
        {
            var department = departmentDto.ToEntity();

            _unitOfWork.DepartmentRepository.Add(department);
            return _unitOfWork.SaveChanges();
        }

        // Updated Department Services
        public int UpdateDepartment(UpdatedDepartmentDto updatedDepartment)
        {
            // we can update some filed and we can not update others depended on bussiness
            // [Name, Code, Description, Date of creation]
            // EF will Update based on Department Id

            _unitOfWork.DepartmentRepository.Update(updatedDepartment.ToEntity());
            return _unitOfWork.SaveChanges();
        }

        // Deleted Department Services ...
        public bool DeleteDepartment(int id)
        {
            var department = _unitOfWork.DepartmentRepository.GetById(id); // get the department that has the id
            if (department is null) return false;

            else
            {
                department.IsDeleted = true;
                _unitOfWork.DepartmentRepository.Update(department);
                return _unitOfWork.SaveChanges() > 0 ? true : false;

                // hard delete
                //int Result = _departmentRepository.Remove(department);  // remove department and return number of row effected
            }
        }
    }
}
