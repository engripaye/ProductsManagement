using ProductsManagement.Data;
using ProductsManagement.Dtos;
using ProductsManagement.Models;

namespace ProductsManagement.Services;

public class ProductService: IProductService
{
    private readonly AppDbContext context;
    public ProductService(AppDbContext appDbContext)
    {
        context = appDbContext;
    }
    public ProductResponse AddProduct (ProductRequest productRequest)
    {
        var product = new Product
        {
            Id = 0, // id will be set by the database
            Name = productRequest.Name,
            Description = productRequest.Description,
            Price = productRequest.Price
        };
        var newProduct = context.Products.Add(product);
        context.SaveChanges();
        
        var response = new ProductResponse
        {
            Id = newProduct.Entity.Id,
            Name = newProduct.Entity.Name,
            Description = newProduct.Entity.Description,
            Price = newProduct.Entity.Price
        };

        return response;

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