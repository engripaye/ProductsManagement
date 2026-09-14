using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        // GET
        [HttpGet]
        public IActionResult GetProduct()
        {
            var products = new[]
            {
                new { Id = 1, name = "Laptop", price = 999.99 },
                new { Id = 2, name = "SmartPhone", price = 499.99 },
                new { Id = 3, name = "iWatch", price = 199.99 }
            };
            return Ok(products);
        }
    }

}