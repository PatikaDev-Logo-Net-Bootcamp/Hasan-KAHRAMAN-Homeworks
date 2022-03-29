using First.API.Models;
using First.App.Business.Abstract;
using First.App.Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace First.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtService jwtService;
        private readonly IUserService _userService;

        public UserController(IJwtService jwtService, IUserService userService)
        {
            this.jwtService = jwtService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll().Select(x=> new UserDto { Name = x.Name });
            return Ok(users);
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(UserModel model)
        {
            var token = jwtService.Authenticate(
                new UserDto 
                { 
                    Name = model.Name, Password = model.Password }
                );

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
