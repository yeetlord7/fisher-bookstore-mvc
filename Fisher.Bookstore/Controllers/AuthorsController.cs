using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Authors controller Index action");
        }

        public IActionResult Featured()
        {
            return Content("This is the about contoller's Featured action");
        }

    }
}