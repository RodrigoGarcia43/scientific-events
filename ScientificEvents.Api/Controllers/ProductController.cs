using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScientificEvents.Core.Services;
using ScientificEvents.Core.Dtos;

namespace ScientificEvents.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController (IProductService productService)
        {
            _productService = productService;
        }

        // GET api/Product
        [HttpGet]
        public async Task<ActionResult<ICollection<ProductDto>>> GetAllAsync()
        {
            var products = await _productService.ListAsync;
            return products;
        }

        // GET api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetAsync(int id)
        {
            var product = await _productService.GetAsync;
            return product;
        }

        // POST api/Product
        [HttpPost]
        public async Task<ActionResult<NewProductDto>> CreateAsync(NewProductDto newProduct)
        {
            var product = await _productService.CreateAsync(newProduct);

            return CreatedAtAction(nameof(GetAsync), new { id = product.Code }, product);
        }

        // DELETE api/Product
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync (string id)
        {
            bool deleted = await _productService.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}