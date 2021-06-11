using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public IActionResult Submit(DojoStudent student)
        {
            if(ModelState.IsValid)
            {
                return View("Results");
            } else {
                return View("Index");
            }
        }
    }
}