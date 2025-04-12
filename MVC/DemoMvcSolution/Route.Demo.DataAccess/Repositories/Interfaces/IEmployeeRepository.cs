using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models.EmployeeModel;

namespace Route.Demo.DataAccess.Repositories.Interfaces
{
    // we used generic intate of repeating the same code
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
         
    }
}
