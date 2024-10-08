using Domain.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductController : ControllerBase
    {
        TypeProductService Service;

        public TypeProductController(TypeProductService service)
        {
            Service = service;
        }

        [HttpGet("get/productId")]
        public async Task<IActionResult> GetProductId()
        {
            return Ok(await Service.GetIdProduct());
        }

        [HttpGet("get/serviceId")]
        public async Task<IActionResult> GetServiceId()
        {
            return Ok(await Service.GetIdService());
        }
    }
}
