using Microsoft.AspNetCore.Mvc;

namespace Group8_Hobbies.Controllers
{
    public class SportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
