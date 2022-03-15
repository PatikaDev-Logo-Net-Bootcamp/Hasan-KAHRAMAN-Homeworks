using Homework1.API.Models;
using Homework1.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homework1.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            _email.Send();
            return Ok();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Json(new {success = true, data = "Hello World. soorry for delete :("});
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Tester")]
        public IActionResult Test([FromForm] TesterModel model)
        {
            var tester = new TesterModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                Image = model.Image,
            };
            return Ok(tester);
            //throw new System.Exception("Middleware Hatası");
        }
        private readonly IEmail _email;
        public HomeController(IEmail email)
        {
            _email = email;
        }


    }
}
