using Microsoft.AspNetCore.Mvc;

namespace Group8_Hobbies.Controllers
{
    public class SportsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Sports";
            ViewBag.Description = "This is where Sports page goes.";
            ViewBag.Wins = 99;
            return View();
        }
    }
}
