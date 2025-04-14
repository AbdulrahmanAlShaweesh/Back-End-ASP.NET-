using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Models.DepartmentModel;
using Route.Demo.DataAccess.Models.Shared.Classes;

namespace Route.Demo.DataAccess.Repositories.Interfaces
{
    // Generic interface (signture)
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity  // should be from base entity or any class that inherit from base entity
    {
        int Add(TEntity entity);
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        TEntity? GetById(int id);
        int Remove(TEntity entity);  // return number of rows affected
        int Update(TEntity entity);  // return number of rows affected
    }
}
