using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Repositories;

namespace RouteDemo.BusinessLogic.Services
{
    class DepartmentServices
    {
        // 1.0 Injection : CLR will understand that we need in inject DepartmentRepsoitoty, but it can not do it
        // we need to add services in services container in program.cs
        public DepartmentServices(DepartmentRepository departmentRepository)
        {

        }
    }
}
