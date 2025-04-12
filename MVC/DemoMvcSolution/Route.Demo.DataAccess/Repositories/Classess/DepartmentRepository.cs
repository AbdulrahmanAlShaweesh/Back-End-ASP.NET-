﻿using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Models.DepartmentModel;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    // Primary Constructor .NET 8 C#12
    public class DepartmentRepository(ApplicationDbContext dbContext) : GenericRepository<Department>(dbContext),  IDepartmentRepository
    // We need constructor chaning
    {

        // note: we used IDepartmentRepository to implement interface inside it we have any interface that belong to the department only
        
    
    }
}
