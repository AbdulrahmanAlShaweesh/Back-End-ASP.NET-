
using System.Linq.Expressions;
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Models.Shared.Classes;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity // THEY should be from the same base entity or class inherit it   
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking) return dbContext.Set<TEntity>().Where(E => E.IsDeleted != true).ToList();
            else return dbContext.Set<TEntity>().Where(E => E.IsDeleted != true).AsNoTracking();
        }

        public IEnumerable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector)
        {
            return dbContext.Set<TEntity>().Where(E => E.IsDeleted != true).Select(selector).ToList();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate) // this allow us to filter based on any data user search by either name , salary etc...
        {
            return dbContext.Set<TEntity>().Where(predicate).ToList(); // used ToList() to make the filter local not in the data by return IEnurable or IQueryable
        }


        public TEntity? GetById(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }


        public int Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            return dbContext.SaveChanges();
        }

        public int Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            return dbContext.SaveChanges();
        }


        public int Update(TEntity entity)
        {
            dbContext.Set<TEntity>().Update(entity); 
            return dbContext.SaveChanges();    
        }

        
    }
}



