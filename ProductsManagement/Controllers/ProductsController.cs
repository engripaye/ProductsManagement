using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductsManagement.Dtos;
using ProductsManagement.Models;
using ProductsManagement.Services;

namespace ProductsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
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

        [HttpPost]
        public IActionResult CreateProduct(ProductRequest product)
        {
            var createdProduct = service.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            try
            {
                service.UpdateProduct(id, product);

                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                service.DeleteProduct(id);

                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}

    