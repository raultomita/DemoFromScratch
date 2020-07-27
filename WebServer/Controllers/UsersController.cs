using Microsoft.AspNetCore.Mvc;

namespace WebServer
{
    public class UsersController : Controller
    {
        public object Index()
        {
            return new string[] { "Maria", "Silviu" };
        }
    }
}
