 

namespace ClothingStore.DataAccess.Repositories.ProductRespository
{
    public interface IProductRepository
    {
        int Add(Product product);                    // Adding Product (take product object)
        IEnumerable<Product> GetAll(bool WithTracking = false);
        Product? GetById(int id);
        int Remove(Product product);                // when we remove a proudct return number of rows affected
        int Update(Product product);                // RETURN number of rows affected
    }
}
