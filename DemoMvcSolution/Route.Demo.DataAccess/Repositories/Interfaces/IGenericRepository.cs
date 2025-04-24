
using System.Linq.Expressions;
using Route.Demo.DataAccess.Models.Shared.Classes;

namespace Route.Demo.DataAccess.Repositories.Interfaces
{
    // Generic interface (signture)
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity  // should be from base entity or any class that inherit from base entity
    {
        // Here it inlcudes all CRUD Methods
        int Add(TEntity entity);
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        IEnumerable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
        int Remove(TEntity entity);  // return number of rows affected
        int Update(TEntity entity);  // return number of rows affected
    }
}


 