using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class CalculatorController : Controller
    {
        public IActionResult PlusTen(int number)
        {
            ViewData["number"] = number;
            ViewData["result"] = number + 10;

            return View();
        }
    }
}