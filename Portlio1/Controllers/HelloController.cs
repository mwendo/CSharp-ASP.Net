using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]

        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }

        [HttpPost("handleData")]
        public RedirectToActionResult Submit()
        {
            return RedirectToAction("Index");
        }
    }
}