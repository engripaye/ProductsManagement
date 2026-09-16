using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductsManagement.Models;
using ProductsManagement.Services;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // static List<Product> products = new List<Product>
        // {
        //     new Product { Id = 1, Name = "Laptop", Description = "Laptop is 12cm long", Price = 999.99M },
        //     new Product { Id = 2, Name = "SmartPhone", Price = 499.99M },
        //     new Product { Id = 3, Name = "iWatch", Price = 199.99M }
        // };

        private readonly IProductService service;

        public ProductsController(IProductService productService)
        {
            service = productService;
        }
        // GET
        [HttpGet]
        public IActionResult GetProducts()
        {
            
            return Ok(service.GetAllProducts());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            var response = service.GetProductById(id);

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
            try
            {

            }
            catch (Exception)
            {
                
            }
            service.UpdateProduct(id, product);
            
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            
            return NoContent();
        }
    }

}