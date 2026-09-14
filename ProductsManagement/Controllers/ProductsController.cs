using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductsManagement.Models;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "Laptop is 12cm long", Price = 999.99M },
            new Product { Id = 2, Name = "SmartPhone", Price = 499.99M },
            new Product { Id = 3, Name = "iWatch", Price = 199.99M }
        };
        // GET
        [HttpGet]
        public IActionResult GetProducts()
        {
            
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
           var response = products.FirstOrDefault(p => p.Id == id);

           if (response == null)
           {
               return NotFound();
           }
           return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            
            return NoContent();
        }
    }

}