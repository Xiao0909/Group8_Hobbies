using Group8_Hobbies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Group8_Hobbies.Controllers
{
    public class RunningController : Controller
    {
        private HobbiesContextModel context { get; set; }
        public RunningController(HobbiesContextModel ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var races = context.Races.OrderBy(n => n.Name).ToList();
            return View(races);
        }
    }
}
