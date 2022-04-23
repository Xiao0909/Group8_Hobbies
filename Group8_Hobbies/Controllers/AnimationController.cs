using Group8_Hobbies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Group8_Hobbies.Controllers
{
    public class AnimationController : Controller
    {
        private HobbiesContextModel context { get; set; }
        public AnimationController (HobbiesContextModel ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var animes = context.Animations
                .OrderBy(n => n.Name).ToList();
            return View(animes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new AnimationModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var anime = context.Animations.Find(id);
            return View(anime);
        }

        [HttpPost]
        public IActionResult Edit(AnimationModel anime)
        {
            if (ModelState.IsValid)
            {
                if(anime.AnimeId == 0)
               
                    context.Animations.Add(anime);
                
                else
                
                    context.Animations.Update(anime);
                
                context.SaveChanges();
                return RedirectToAction("Index", "Animation");
            }
            else
            {
                ViewBag.Action = (anime.AnimeId == 0) ? "Add" : "Edit";
                return View(anime);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Action = "Edit";
            var anime = context.Animations.Find(id);
            return View(anime);
        }

        [HttpPost]
        public IActionResult Delete(AnimationModel model)
        {
            context.Animations.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Animation");

        }
    }
}
