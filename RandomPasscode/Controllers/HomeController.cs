using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static int count = 1;
        public static string Bank = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("num", count);
            ViewBag.Count = HttpContext.Session.GetInt32("num");
            Random rand = new Random();
            string RandomPassword = "";
            for(int i = 0; i < 14; i++)
            {
                char yellow = Bank[rand.Next(0, Bank.Length)];
                RandomPassword += yellow;
            }
            ViewBag.RandomPassword = RandomPassword;
            return View();
        }

        [HttpPost("newPasscode")]
        public IActionResult NewPasscode()
        {
            count = count + 1;
            return RedirectToAction("Index");
        }
    }
}
