
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ApplicationDbContext _dbContext; 

        // when someone create an object from Unit of work, CLR will inject Both IEmployee and IDepartment Repotories and allow to work with same changes
        public UnitOfWork(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository, ApplicationDbContext dbContext)
        {
            // we did it, to ask them in below Siguatures
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;   
            _dbContext = dbContext;
        }

        public IEmployeeRepository EmployeeRepository => _employeeRepository; // will get the repo that CLR create it

        public IDepartmentRepository DepartmentRepository => _departmentRepository; // will get the repo that CLR create it

        public int SaveChanges() => _dbContext.SaveChanges();
    }
}
