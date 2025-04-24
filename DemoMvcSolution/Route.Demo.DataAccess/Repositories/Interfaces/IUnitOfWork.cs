

namespace Route.Demo.DataAccess.Repositories.Interfaces
{
    public interface IUnitOfWork  // we work against dbcontext any thing out side uow can only work with UoW as it works with dbcontext
    {
        // we need to define read only prof for each repository,
        // it should be get ony becouse we do not want any one to change it
        public IEmployeeRepository EmployeeRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }

        int SaveChanges();  // this signture for function : work with it when we need to save changes after finishing all operations
    }
}
