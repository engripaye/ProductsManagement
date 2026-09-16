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
        var product = context.Products.Find(id);

        return product;
    }

    public void UpdateProduct(int id, Product product)
    {
        var existingProduct = context.Products.Find(id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            context.SaveChanges();
        }
    }
}