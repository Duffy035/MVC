using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning4___ModelControllerView___Razor.Models;

namespace Föreläsning4___ModelControllerView___Razor.Controllers
{
    public class BeerController : Controller
    {
        // GET: Beer
        public ActionResult List()
        {
            return View(beers);
        }

        private static List<BeerDetailsModel> beers = new List<BeerDetailsModel>
        {
            new BeerDetailsModel {ID = 1, Name = "Eriksberg", Description = "Soft and smooth", AlcoholVolume = 5.3M},
            new BeerDetailsModel {ID = 2, Name = "Marisetad", Description = "Soft", AlcoholVolume = 6.5M},
            new BeerDetailsModel {ID = 3, Name = "Carlsberg", Description = "Smokey", AlcoholVolume = 4.5M},
            new BeerDetailsModel {ID = 4, Name = "AJ:s Cider", Description = "Good", AlcoholVolume = 3.5M}
        };
    }
}