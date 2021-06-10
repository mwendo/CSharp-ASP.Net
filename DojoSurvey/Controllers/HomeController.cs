using System;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Form(string name, string location, string favoriteLanguage, string comment)
        {
            ViewBag.Name =  name;
            ViewBag.Location =  location;
            ViewBag.Language =  favoriteLanguage;
            ViewBag.Comment =  comment;
            return View("Results");
        }
    }
}