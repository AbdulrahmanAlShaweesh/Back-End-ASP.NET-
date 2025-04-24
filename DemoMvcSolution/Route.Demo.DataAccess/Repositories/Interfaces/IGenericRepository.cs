
using System.Linq.Expressions;
using Route.Demo.DataAccess.Models.Shared.Classes;

namespace Route.Demo.DataAccess.Repositories.Interfaces
{
    // Generic interface (signture)
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity  // should be from base entity or any class that inherit from base entity
    {
        // Here it inlcudes all CRUD Methods
        // since we use UoW, all int signture must be void, becouse it will not return any thing and will not save change
        void Add(TEntity entity); 
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        IEnumerable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
        void Remove(TEntity entity);  // return number of rows affected
        void Update(TEntity entity);  // return number of rows affected
    }
}


 