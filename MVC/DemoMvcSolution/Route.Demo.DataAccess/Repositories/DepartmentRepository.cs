using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Data.DbContexts;

namespace Route.Demo.DataAccess.Repositories
{
    class DepartmentRepository  // Telling CLR: when anyone create an object from DepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        // CLR need to create an object from DbContext [ Injection ] 
        // We need to registor the container inside the program by congigrating a new serves.
        public DepartmentRepository(ApplicationDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }
        // CRUD Operators only on logic inside it
        // To Implement with any of the following Action, we need to contect to the Db
        // 1. Get All
        // 2. Get By ID
        // 3. Update
        // 4. Delete
        // 5. Add
    }
}
