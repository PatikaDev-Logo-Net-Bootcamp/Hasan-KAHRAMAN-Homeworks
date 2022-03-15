using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        // GET: api/<UserController>
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return Ok();
        }

        // GET: api/<UserController>
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return Ok();
        }


    }
}
