using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}