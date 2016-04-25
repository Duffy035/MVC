using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Föreläsning1._2_old_MVC_.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult TopTen()  //Vi har ändrat från 'index' till 'TopTen'
        {
            return View();
        }
    }
}