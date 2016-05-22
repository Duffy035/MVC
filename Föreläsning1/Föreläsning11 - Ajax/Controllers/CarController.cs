using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Föreläsning11___Ajax.Models;

namespace Föreläsning11___Ajax.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        //del 2
        public PartialViewResult _Create(int id)
        {
            Car car = new Car { PersonId = id };
            return PartialView(viewName: "_Create", model: car);  //Skapar våra vyer här - högerklick, 'add view'. Sedan skapat olika, Details, Create, baserat på vår klass Car
        }
        
        //del 3?
        public void _HideCreate() { }


        //del 4 - Skapa bil
        public PartialViewResult _Create2(int id)
        {
            Car car = new Car { PersonId = id };
            return PartialView(viewName: "_Create2", model: car); //Skapar våra vyer här - högerklick, 'add view'
        }

        //del 4 - För vår POST
        [HttpPost]
        public string _Create2(int id, Car model)
        {
            return "A car was successfully created :-)";
        }



    }
}