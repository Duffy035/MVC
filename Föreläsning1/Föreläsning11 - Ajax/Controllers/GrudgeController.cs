using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning11___Ajax.Models;

namespace Föreläsning11___Ajax.Controllers
{
    public class GrudgeController : Controller
    {
        // GET: Grudge
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _GrudgesForRabbit(int id)
        {
            List<Grudge> grudges = ((Rabbit)Session["Rabbit"]).Grudges;
            return PartialView(grudges);
        }

        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grudge model)  //Vi skapr vå _Create-vy
        {
            //hämtar från Session - ugly code
            ((Rabbit)Session["Rabbit"]).Grudges.Add(model);   //Addar listan med grudges på kaninens grudgelista
            return RedirectToAction(actionName: "_GrudgesForRabbit",
                routeValues: new { id = 9 });
        }

    }
}