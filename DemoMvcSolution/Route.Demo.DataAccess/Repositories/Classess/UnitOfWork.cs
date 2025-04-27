
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    public class UnitOfWork : IUnitOfWork
    {
        // lazy will make CLR create when need it, not every time create an object create all repositories
        private readonly Lazy<IDepartmentRepository> _departmentRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly ApplicationDbContext _dbContext;

        // when someone create an object from Unit of work, CLR will inject Both IEmployee and IDepartment Repotories and allow to work with same changes
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            // we did it, to ask them in below Siguatures
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(dbContext));
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(dbContext));
            _dbContext = dbContext;
        }

        // will create an object from it when need it
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value; // will get the repo that CLR create it

        public IDepartmentRepository DepartmentRepository => _departmentRepository.Value; // will get the repo that CLR create it

        public int SaveChanges() => _dbContext.SaveChanges();
    }
}
