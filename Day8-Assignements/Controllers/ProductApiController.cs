using Day8Assignements.Models;
using Day8Assignements.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day8Assignements.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
            public IProductService _productService;
            public ProductApiController(IProductService productService) 
            {
                _productService = productService;
            }

            [HttpGet]
            public IActionResult DisplayProducts()
            {
                return Ok(_productService.DisplayProducts());
            }

            [HttpGet("{id}")]
            public IActionResult getProductById(int id)
            {
                Product productObj = _productService.getProductById(id);
                if (productObj != null)
                {
                    return Ok(productObj);
                }
                else
                { return NotFound(new { status = "Product is not found!" }); }
            }

            [HttpPost]
            public IActionResult AddProduct(Product product)
            {
                string str = _productService.AddProduct(product);
                return Ok(new { status = str });
            }

            [HttpPut]
            public IActionResult EditProduct(Product product)
            {
                string str = _productService.EditProduct(product);
                return Ok(new { status = str });

            }

            [HttpDelete("{id}")]
            public IActionResult DeleteProduct(int id)
            {
                string str = _productService.DeleteProduct(id);
                if (str.Equals("1"))
                {
                    return Ok(new { status = "Product deleted from the database successfully..." });
                }
                else
                { return NotFound(new { status = "Product is not found!" }); }

            }

        }
}
