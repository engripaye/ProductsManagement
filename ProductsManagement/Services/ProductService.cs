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
    public Product AddProduct (Product product)
    {
        var newProduct = context.Products.Add(product);
        context.SaveChanges();
        return newProduct.Entity;

    }
    
    public void DeleteProduct(int id)
    {
        var product = context.Products.Find(id);
        if (product != null)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
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