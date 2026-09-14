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
        public IActionResult GetProduct()
        {
            
            return Ok(products);
        }
    }

}