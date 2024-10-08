using Domain.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserService Service { get; set; }

        public UserController(UserService service)
        {
            Service = service;
        }

        [HttpPost("registration/")]
        public async Task<IActionResult> Post([FromBody] Domain.DTO.User User)
        {
           return Ok(await Service.PostAsync(User));
        }
    }
}
