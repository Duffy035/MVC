using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning4___ModelControllerView___Razor.Models;
using System.Text;

namespace Föreläsning4___ModelControllerView___Razor.Controllers
{
    public class KungFuController : Controller
    {
        // GET: KungFu
        public ActionResult FullDetails()
        {
            var masters = new List<KungFuMaster>
            {
                new KungFuMaster {ID = 1, Name = "Keit Kernspserceht", Age = 67, KungFuStyle = "WingTshun", Level = "Master of comprehension"},
                new KungFuMaster {ID = 2, Name = "Freddie", Age = 39, KungFuStyle = "WingTshun", Level = "12 student grade"},
                new KungFuMaster {ID = 3, Name = "Bruce Lee", Age = 80, KungFuStyle = "WingTshun", Level = "Ultimate Master"}
            };

            return View(masters);
        }

        //DENNA METOD HADE VI ANVÄNT OM VI T.EX. VILJAT SKAPA EN 'CREATE' SEN GJORT EN NY VY MED DEN, SOM GJORTS SOM 'CREATE'
        //public ActionResult FullDetailsNew()
        //{
        //    var masters = new List<KungFuMaster>
        //    {
        //        new KungFuMaster {ID = 1, Name = "Keit Kernspserceht", Age = 67, KungFuStyle = "WingTshun", Level = "Master of comprehension"},
        //        new KungFuMaster {ID = 2, Name = "Freddie", Age = 39, KungFuStyle = "WingTshun", Level = "12 student grade"},
        //        new KungFuMaster {ID = 3, Name = "Bruce Lee", Age = 80, KungFuStyle = "WingTshun", Level = "Ultimate Master"}
        //    };

        //    return View(masters);
        //}

        public ActionResult Stars()
        {
            return View();
        }
        public ActionResult StarsFromController()  //Ex. med Seperation of concern
        {
            return View();
        }
    }

    //Denna klassen är en extension för StarFromController
    public static class ExtensionMethods
    {
        public static string RatingsStars(this HtmlHelper helper, int numberOfStars)
        {
            StringBuilder oh = new StringBuilder();
            oh.Append(" <span style='color: orange'>");

            for (int i = 0; i < numberOfStars; i++)
            {
                oh.Append("*");
            }
            oh.Append("</span>");
            return oh.ToString();
        }
    }
}