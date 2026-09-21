using Common.Model;

namespace Common.Database;

public class InMemoryDatabase : IDatabase
{
    private List<Product> _products;
    public InMemoryDatabase()
    {
        _products = new List<Product>();
    }
    public void Create(Product product)
    {
        _products.Add(product);
    }

    public void Delete(Product product)
    {
        _products.Remove(product);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product? GetProductById(int productId)
    {
        return _products.Where(x => x.Id == productId).FirstOrDefault();
    }

    public void Update(Product product)
    {
        var productFound = _products.Where(x => x.Id == product.Id).FirstOrDefault();

        if (productFound is not null)
        {
            productFound.Name = product.Name;
            productFound.Description = product.Description;
        }

        throw new NotImplementedException();
    }
}