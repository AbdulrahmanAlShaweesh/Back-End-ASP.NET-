using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DataAccess.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        int Add(Category category);  
        IEnumerable<Category> GetAll(bool WithTracking = false);
        Category? GetById(int id);
        int Remove(Category category);
        int Update(Category category);

    }
}
