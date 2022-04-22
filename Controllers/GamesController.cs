using Group8_Hobbies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Group8_Hobbies.Controllers
{
    public class GamesController : Controller
    {
        private HobbiesContextModel context { get; set; }

        public GamesController(HobbiesContextModel ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var games = context.Games.OrderBy(n => n.GameName).ToList();
            return View(games);
        }
    }
}
