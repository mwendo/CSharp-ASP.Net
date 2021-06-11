using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
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

        [HttpGet("names")]
        public IActionResult Names()
        {
            // to a View that has a defined a model as @model string[]
            string[] names = new string[]
            {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };
            return View(names);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                10,
                43,
                5
            };
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<string> users = new List<string>();
            users.Add("Moose Phillips");
            users.Add("Sarah");
            users.Add("Jerry");
            users.Add("Rene Ricky");
            users.Add("Barbarah");

            return View(users);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            string[] user = new string[]
            {
                "Moose Phillips"
            };
            return View(user);
        }
    }
}