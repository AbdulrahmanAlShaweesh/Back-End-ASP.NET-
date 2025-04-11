 
using Route.Demo.DataAccess.Data.DbContexts;

namespace Route.Demo.DataAccess.Repositories.DepartmentRepo
{
    // Primary Constructor .NET 8 C#12
    public class DepartmentRepository(ApplicationDbContext dbContext) : IDepartmentRepository
    // Telling CLR: when anyone create an object from DepartmentRepository
    {


        // CRUD Operators only logic inside it
        // To Implement with any of the following Action, we need to contect to the Db

        // 1. Get All
        public IEnumerable<Department> GetAll(bool WithTracking = false) // sometime we need to track when we RETRIVE data from db 
        {
            // if need to trach which the deualt behaior of EF
            // this is not a logic, it is just data access
            if (WithTracking)
                return dbContext.Departments.ToList();
            else
                return dbContext.Departments.AsNoTracking();  // does not track the changes

        } 
        // 2. Get By ID
        public Department? GetById(int id) => dbContext.Departments.Find(id);

        // 3. Update : We will recive the department that need to be updated and return how many rows are effected
        public int Update(Department department)
        {
            dbContext.Departments.Update(department); // Update locally, we need to use savechanges to update to db
            return dbContext.SaveChanges();   // will return number of rows that has been changed in db

        }

        // 4. Delete
        public int Remove(Department department)
        {

            dbContext.Departments.Remove(department);
            return dbContext.SaveChanges();
        }

        // 5. Add
        public int Add(Department department)
        {
            dbContext.Departments.Add(department);
            return dbContext.SaveChanges();
        }
    }
}
