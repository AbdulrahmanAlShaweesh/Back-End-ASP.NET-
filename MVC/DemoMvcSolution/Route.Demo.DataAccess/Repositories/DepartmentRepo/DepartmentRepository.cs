using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Data.DbContexts;

namespace Route.Demo.DataAccess.Repositories.DepartmentRepo
{
    // Primary Constructor .NET 8 C#12
    public class DepartmentRepository(ApplicationDbContext dbContext) : IDepartmentRepository
    // Telling CLR: when anyone create an object from DepartmentRepository
    {
        // CLR need to create an object from DbContext [ Injection ] 
        // We need to registor the container inside the program by congigrating a new serves.
        private readonly ApplicationDbContext _dbContext = dbContext;


        // CRUD Operators only on logic inside it
        // To Implement with any of the following Action, we need to contect to the Db
        // 1. Get All
        public IEnumerable<Department> GetAll(bool WithTracking = false) // sometime we need to track when we tritrive data from db 
        {
            // if need to trach which the deualt behaior of EF
            // this is not a logic, it is just data access
            if (WithTracking)
                return _dbContext.Departments.ToList();
            else
                return _dbContext.Departments.AsNoTracking();  // does not track the changes

        }
        // 2. Get By ID
        public Department? GetById(int id) => _dbContext.Departments.Find(id);

        // 3. Update : We will recive the department that need to be updated and return how many rows are effected
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department); // Update locally, we need to use savechanges to update to db
            return _dbContext.SaveChanges();   // will return number of rows that has been changed in db

        }

        // 4. Delete
        public int Remove(Department department)
        {

            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }

        // 5. Add
        public int Add(Department department)
        {
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }
    }
}
