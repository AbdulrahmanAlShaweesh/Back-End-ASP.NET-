using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Data.DbContexts;
using Route.Demo.DataAccess.Models.Shared.Classes;
using Route.Demo.DataAccess.Repositories.Interfaces;

namespace Route.Demo.DataAccess.Repositories.Classess
{
    public class GenericRepository<TEntity>(ApplicationDbContext _dbContext) : IGenericRepository<TEntity> where TEntity : BaseEntity // THEY should be from the same base entity or class inherit it   
    {

        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking) return _dbContext.Set<TEntity>().Where(E => E.IsDeleted != true).ToList();
            else return _dbContext.Set<TEntity>().Where(E => E.IsDeleted != true).AsNoTracking();
        }

        public TEntity? GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }


        public int Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }


        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity); 
            return _dbContext.SaveChanges();    
        }
    }
}
