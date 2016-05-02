using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning4___Övning.Models;

namespace Föreläsning4___Övning.Controllers
{
    public class KaramellerController : Controller
    {
        // GET: Karameller
        public ActionResult KaramellerDetails()
        {
            var karamell = new Karameller
            {
                Name = "Dumle",
                Color = "Brown",
                Amount = 10,
                Flavor = "Chocolate and Fudge",
                Distributor = "Fazer",
                Nisse = "Nissssse"
                
            };
            return View(karamell);
        }
    }
}