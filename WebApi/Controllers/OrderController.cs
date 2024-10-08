using Api.DataBase.Models;

using Domain.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public OrderService Service { get; set; }

        public OrderController(OrderService service)
        {
            Service = service;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(Domain.DTO.Order order)
        {
           return Ok(await Service.PostAsync(order));
        }
    }
}
