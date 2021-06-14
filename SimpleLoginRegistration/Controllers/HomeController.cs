using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers
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

        [HttpPost("create/user")]
        public IActionResult CreateUser(IndexViewModel modelData)
        {
            Registration submittedUser = modelData.NewUser;
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            else {
                return View ("Index");
            }
        }

        [HttpPost("login/user")]
        public IActionResult LoginUser(IndexViewModel modelData)
        {
            Login submittedUser = modelData.CurrentUser;
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            else {
                return View ("Index");
            }
        }
    }
}