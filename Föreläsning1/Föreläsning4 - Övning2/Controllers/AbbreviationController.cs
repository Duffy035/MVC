using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Föreläsning4___Övning2.Models;

namespace Föreläsning4___Övning2.Controllers
{
    public class AbbreviationController : Controller
    {
        // GET: Abbreviation
        public ActionResult AbbreviationDetails()
        {
            var abbrevation = new Abbreviation
            {
                ShortOne = "IE",
                Description = "Internet Explorer"
            };
            return View(abbrevation);
        }

        private static List<Abbreviation> GetList = new List<Abbreviation>
            {
                new Abbreviation {Description = "Additional Content", ShortOne = "AD"},
                new Abbreviation {Description = "Arc Data Files", ShortOne = "ADF"},
                new Abbreviation {Description = "Class IDentifier", ShortOne = "CLSID"},
                new Abbreviation {Description = "Componenet Object Model", ShortOne = "COM"},
            };

        public ActionResult AbbrevationNoScaffolding()
        {
            return View(GetList);
        }

        public ActionResult AbbrevationWithScaffolding()
        {
            return View(GetList);
        }
    }
}
