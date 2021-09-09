using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week9_Lab2.Models;

namespace week9_Lab2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View();
        }

        //public IActionResult MyPage()
        //{
        //    ViewData["ActionMovie"] = "Die Hard";
        //    ViewData["HorrorMovie"] = "The Shining";
        //    ViewData["ComedyMovie"] = "Caddyshack";
        //    return View();
        //}
        //public IActionResult MyPagee(string actionMov, string horrorMov, string comedyMov)
        //{
        //    ViewData["ActionMovie"] = actionMov;
        //    ViewData["HorrorMovie"] = horrorMov;
        //    ViewData["ComedyMovie"] = comedyMov;
        //    return View();
        //}

        [HttpPost]
        public IActionResult MyPage(Movies movies)
        {
            return View(movies);
        }

    }
}
