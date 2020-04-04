using Microsoft.AspNetCore.Mvc;

namespace WebApplication
{
    public class CalculatorController : Controller
    {

        [Route("[controller]/{firstNumber:int}/{secondNumber:int}")]
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["result"] = firstNumber + secondNumber;

            return View();
        }
    }
}