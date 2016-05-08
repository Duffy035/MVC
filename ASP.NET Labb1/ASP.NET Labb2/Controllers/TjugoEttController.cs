using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Labb2.Models;

namespace ASP.NET_Labb2.Controllers
{
    public class TjugoEttController : Controller
    {
        // GET: TjugoEtt
        public ActionResult Play()
        {
            ViewBag.result = string.Empty;
            TjugoEttModels.CurrentNumber = 0;
            TjugoEttModels.SetStartPlayer();
            return View();
        }

        [HttpPost]
        public ActionResult Play(string buttonValue)
        {
            int choice = int.Parse(Request["choice"]);
            TjugoEttModels.CurrentNumber += choice;
            ViewBag.result = TjugoEttModels.HandleGameResult();
            return View();
        }
    }
}