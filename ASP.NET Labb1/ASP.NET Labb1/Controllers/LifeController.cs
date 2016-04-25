using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Labb1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult SuperMario(object id) //object tar både siffror o värde
        {
            ViewBag.MarioAmounts = "You have:" + id;
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Live()
        {
            return View();
        }
    }
}