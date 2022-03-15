using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [Route("GetHomework")]
        [HttpGet]
        public IActionResult GetHomework()
        {
            return Ok();
        }
        [Route("CreateHomework")]
        [HttpPost]
        public IActionResult CreateHomework()
        {
            return Ok();
        }
        [Route("DeleteHomework")]
        [HttpDelete]
        public IActionResult DeleteHomework()
        {
            return Json(new { success = true, data = "Hello World. soorry for delete :(" });
        }
        //To hide UpdateHomework endpoint, we use this attribute.       //IgnoreApi.false => endpoint will be visible
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("UpdateHomework")]
        [HttpPut]
        public IActionResult UpdateHomework()
        {
            return Ok();
        }


    }
}
