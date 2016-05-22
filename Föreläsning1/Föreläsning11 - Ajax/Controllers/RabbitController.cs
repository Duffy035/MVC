using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning11___Ajax.Models;

namespace Föreläsning11___Ajax.Controllers
{
    public class RabbitController : Controller
    {
        // GET: Rabbit
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Rabbit rabbit = new Rabbit()
            {
                Id = 666,
                BirthDate = new DateTime(year: 2006, month: 06, day: 06),
                AngerLevel = 6,
                Name = "Honey Bunny",
                Grudges = new List<Grudge>()
                {
                    new Grudge() {ID = 7, TargetName = "Innocent rabbits", Reason = "ADHD"},
                    new Grudge() {ID = 8, TargetName = "People", Reason = "Snitch"}

                }
                //spara till DB... osv... vi gör fultrick... Session...
            };
            Session["Rabbit"] = rabbit;
            return View(rabbit);
        }
    }
}