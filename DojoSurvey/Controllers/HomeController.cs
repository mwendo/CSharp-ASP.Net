using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("sendData")]
        public IActionResult Form(DojoStudent student)
        {
            return View("Results", student);
        }
    }
}