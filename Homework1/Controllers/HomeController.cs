using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Created to show if user logged in successfully.
        public IActionResult LoginSuccess()
        {
            return Ok(new ResponseViewModel { Success = true, Data= "Giriş İşlemi Başarılı", Error = null});
        }
        //Created to show if user can not logged in successfully.
        public IActionResult LoginFail()
        {
            return BadRequest(new ResponseViewModel { Success = false, Data = null, Error = "Hatalı Giriş" });
        }
        //Created to show Login Page
        public IActionResult Login()
        {
            return View();
        }
        //Created to submit user request.
        [HttpPost]
        public IActionResult Login( UserViewModel model )
        {
            if (ModelState.IsValid)
            {
                //user sees LoginSuccess action if successfully logges in.
                return BadRequest(new ResponseViewModel { Success = false, Data = null, Error = "Hatalı Giriş" });
                //return RedirectToAction("LoginSuccess");
            }else
            {
                //user sees LoginFail action if fails to log in. 
                return RedirectToAction("LoginFail");
                //return View("Login");
            }
        }
    }
}
