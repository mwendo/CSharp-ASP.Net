using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey_MVC.Models;

namespace DojoSurvey_MVC.Controllers
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

        [HttpPost("Submit")]
        public IActionResult Submit(DojoStudent student)
        {
            if(ModelState.IsValid)
            {
                return View("Results", student);
            } 
            else 
            {
                return View("Index");
            }
        }

        [HttpGet("Results")]
        public IActionResult Results(DojoStudent student)
        {
            return View("Results");
        }
    }
}
