using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.DataAccess.Data.DbContexts;

namespace ClothingStore.DataAccess.Repositories.CategoryRepository
{
    public class CategoryRepository(ApplicationDbContext dbContext) : ICategoryRepository
    {

        public IEnumerable<Category> GetAll(bool WithTracking = false)
        {
            if (WithTracking) return dbContext.Categories.ToList();
            else return dbContext.Categories.AsNoTracking();
          
        }

        public Category? GetById(int id) => dbContext.Categories.Find(id);
       

        public int Add(Category category)
        {
            dbContext.Add(category);   // Add locally
            return dbContext.SaveChanges();
        }
 
        public int Remove(Category category)
        {
            dbContext.Remove(category);
            return dbContext.SaveChanges();
        }

        public int Update(Category category)
        {
            dbContext.Update(category);
            return dbContext.SaveChanges();
        }
    }
}
