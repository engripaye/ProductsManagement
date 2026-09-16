using ProductsManagement.Data;
using ProductsManagement.Models;

namespace ProductsManagement.Services;

public class ProductService: IProductService
{
    private readonly AppDbContext context;
    public ProductService(AppDbContext appDbContext)
    {
        context = appDbContext;
    }
    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }
    
    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        var products = context.Products.ToList();
        return products;
    }

    public Product? GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(int id, Product product)
    {
        throw new NotImplementedException();
    }
}