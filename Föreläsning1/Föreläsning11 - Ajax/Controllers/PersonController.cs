using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning11___Ajax.Models;

namespace Föreläsning11___Ajax.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Person person = new Person()
            {
                ID = 2,
                Name = "Calle",
                BirthDate = new DateTime(year:1985, month:03, day:19)
            };
            return View(person);
        }

        public string HitMe()  //Vår metod som skriver ut vad som händer när vi trycker på Ajaxlänken
        {
            return "Pow!!! Punch!! -";
        }
    }
}