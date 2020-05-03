using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Controllers
{
    public class HomeController : Controller
    {
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Form(User user)
        {
            if (user != null && user.Name != null)
            {
                ViewBag.Name = user.Name;
                return View("Welcome");
            }
            return View();
        }

    }
}