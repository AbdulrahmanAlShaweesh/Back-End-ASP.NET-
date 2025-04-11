
using ClothingStore.DataAccess.Data.DbContexts;


namespace ClothingStore.DataAccess.Repositories.ProductRespository
{
    public class ProductRepository(ApplicationDbContext _dbContext) : IProductRepository
    {

        //////////////////////////////////////////////////// CRUD ////////////////////////////////////////////
        public IEnumerable<Product> GetAll(bool WithTracking = false)
        {
            if (WithTracking) return _dbContext.Products.ToList();
            else return _dbContext.Products.AsNoTracking();
        }


        // GET Product BY ID
        public Product? GetById(int id) => _dbContext.Products.Find(id);


        // Add Product
        public int Add(Product product)
        {
            _dbContext.Add(product);               // Add Locally
            return _dbContext.SaveChanges();       // Save int DB
        }


        public int Remove(Product product)
        {
            _dbContext.Remove(product);
            return _dbContext.SaveChanges();
        }

        public int Update(Product product)
        {
            _dbContext.Update(product);
            return _dbContext.SaveChanges();
        }
    }
}
