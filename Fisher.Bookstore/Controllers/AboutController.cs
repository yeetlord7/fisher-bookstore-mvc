using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the about contoller's Index action");
        }

        public IActionResult History()
        {
            return Content("This is the about contoller's History's action");
        }

        public IActionResult Location()
        {
            return Content("This is the about contoller's Location's action");
        }


    }
}