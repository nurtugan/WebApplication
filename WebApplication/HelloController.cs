using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class HelloController : Controller
    {
        public string Index()
        {            
            return "Hello from controller";
        }
    }
}