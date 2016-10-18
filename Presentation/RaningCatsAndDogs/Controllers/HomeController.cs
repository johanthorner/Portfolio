using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RaningCatsAndDogs.Models;

namespace RaningCatsAndDogs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            Dog dog = new Dog()
            {ID = 7, Name = "Lord Wooofington", BirthDate = new DateTime(year: 2005, month: 06, day: 27)};
            return View(dog);
        }

        public string Bark()
        {
            return "Woof!";
        }
    }
}