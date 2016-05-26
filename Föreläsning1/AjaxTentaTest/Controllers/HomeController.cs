using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTentaTest.Models;

namespace AjaxTentaTest.Controllers
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
            Person person = new Person()
            {
                Id = 1,
                Name = "Roger",
                BirthDate = new DateTime(year: 1954, month: 03, day: 12)
            };
            return View(person);
        }

        public string HitMe()
        {
            return "  Pow-Punch!  ";
        }

        public string Hide()
        {
            return "";
        }

        public ActionResult GetCarCreate(int id)
        {
            return RedirectToAction(actionName: "_Create2",
                controllerName: "Car",
                routeValues: new { id });

            //TODO Forsätt här...
/*
            return RedirectToAction(actionName: "_Create",
                controllerName: "Car",
                routeValues: new { id });
*/
        }
    }
}