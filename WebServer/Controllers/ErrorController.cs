using Microsoft.AspNetCore.Mvc;

namespace WebServer.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Error was thrown");
        }
    }
}
