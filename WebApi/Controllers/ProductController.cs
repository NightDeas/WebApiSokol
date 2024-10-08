using Domain.Services;

using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Reflection.Metadata.Ecma335;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public Domain.Services.ProductService Service { get; set; }

        public ProductController(ProductService service)
        {
            Service = service;
        }

        [HttpGet("all/")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Service.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await Service.GetAsync(id));
        }
        [HttpGet("{id:guid}/count")]
        public async Task<IActionResult> GetCount(Guid id)
        {
            var product = await Service.GetAsync(id);
            if (product == null)
                return NotFound("Product not found");
            return Ok(await Service.GetCount(id));
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]Domain.DTO.Product product)
        {
            return Ok(await Service.PostAsync(product));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountAsync(Guid id, int newCount)
        {
            if (newCount < 0)
                return BadRequest("newCount < 0");
            var product = await Service.GetAsync(id);
            if (product == null)
                return NotFound("Product not found");
            return Ok(await Service.UpdateCountAsync(id, newCount));
        }




    }
}
