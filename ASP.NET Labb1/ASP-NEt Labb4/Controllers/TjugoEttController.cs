using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NEt_Labb4.Models;

namespace ASP_NEt_Labb4.Controllers
{
    public class TjugoEttController : Controller
    {
        // GET: TjugoEtt
        public ActionResult Play()
        {
            TjugoEttModels.CurrentNumber = 0;
            TjugoEttModels.SetStartPlayer();
            return View();
        }

        public string NextTurn(int buttonValue)
        {
            TjugoEttModels.CurrentNumber += buttonValue;
            return TjugoEttModels.HandleGameResult();
        }
    }
}