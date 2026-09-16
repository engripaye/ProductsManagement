using ProductsManagement.Dtos;
using ProductsManagement.Models;

namespace ProductsManagement.Services;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int id);
    ProductResponse AddProduct(ProductRequest product);
    void UpdateProduct(int id, Product product);
    void DeleteProduct(int id);

}