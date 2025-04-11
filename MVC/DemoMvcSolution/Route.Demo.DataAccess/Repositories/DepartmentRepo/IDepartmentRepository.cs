namespace Route.Demo.DataAccess.Repositories.DepartmentRepo
{
    public interface IDepartmentRepository
    {
        int Add(Department department);
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        int Remove(Department department);  // return number of rows affected
        int Update(Department department);  // return number of rows affected
    }
}