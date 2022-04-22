using Group8_Hobbies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Group8_Hobbies.Controllers
{
    public class SportsController : Controller
    {
        private HobbiesContextModel context { get; set; }

        public SportsController (HobbiesContextModel ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var sports = context.Sports.OrderBy(n => n.SportsName).ToList();
            return View(sports);
        }
    }
}
