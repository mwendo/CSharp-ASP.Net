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

        [HttpGet("/projects")]

        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("/contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}