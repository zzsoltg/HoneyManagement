using Common.Model;

namespace Common.Database;

public interface IDatabase
{
    void Create(Product product);
    void Update(Product product);
    void Delete(Product product);
    Product? GetProductById(int productId);
    IEnumerable<Product> GetAllProducts();
}