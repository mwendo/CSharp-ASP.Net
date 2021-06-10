using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")] // default is a Get request
        public string Index()
        {
            return "Hello From Controller";
        }

        // localhost:5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "HI Again!";
        }
        // localhost:5000/users/???
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "Chicago")
                return $"Hello {username} from {location}.   Go Bears!";
            return $"Hello {username} from {location}";
        }
    }
}