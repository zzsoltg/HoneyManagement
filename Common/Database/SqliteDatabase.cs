using Common.Model;

namespace Common.Database;

public class SqliteDatabase : IDatabase, IDisposable
{
    private ApiaryContext _context;
    public SqliteDatabase()
    {
        _context = new ApiaryContext();
    }
    public void Dispose()
    {
        _context?.Dispose();
    }

    public void Create(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Delete(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return [.. _context.Products];
    }

    public Product? GetProductById(int productId)
    {
        return _context.Products.FirstOrDefault(p => p.Id == productId);
    }

    public void Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }
}
