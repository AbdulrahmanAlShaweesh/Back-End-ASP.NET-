using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    public class EmployeeRepository(ApplicationDbContext _dbContext) : GenericRepository<Employee>(_dbContext), IEmployeeRepository
    {
    }
}
