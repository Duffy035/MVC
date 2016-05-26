using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Vår egen tillagda controller, med olika exempel. 

namespace Föreläsnign_3___Views.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Driver()
        {
            //Bygger modell och skicka till view:n
            return View();
        }

        //Skapar en helt ny sida genom att göra en ny metod. Tänk att det är som mappar
        public ActionResult BrumBrum()
        {
            return View();
        }

        public ActionResult ViewDataTransfer()
        {
            //Vi använder en viewdata och skickar till vår view
            ViewData["beauty"] = "Det är en häst med skägg...";  //Använder sig av nycklar i form av strängar
            return View();
        }



        //[ActionName("Lisa")] //dödar min Lisa-view?
        public ActionResult ViewBagTransfer()
        {
            //En viewbag: som om vi lägger till en property på vår klass, och namnger den:
            ViewBag.Lisa = "Lisa är en snärta från Märsta";
            return View();
        }



        public ViewResult OddNumbers()
        {
            var oddNumbers = (ParallelEnumerable.Range(10, 40)).Where(x => x % 2 != 0).Select(x => x).ToList();
            ViewData.Model = oddNumbers;
            return View();
        }
    }
}

//skillanden mellan viewbag & viewdata? 
//Jo det är hela tiden 'nyckel:värden' som vi hämtar från controllern och skickar till vår view. 

//Viewbag är en dynamisk property, 
//-använder dynamic från C# 
//-kräver inte typecasting för komplexa datatyper. 
//(Denna är rekommenderad att använda.)

//ViewData är en dictionary, 
//-ärver av ViewDataDictionary, 
//-string som nyckel, 
//-värdet kräver typcasting och null-check för att undvika fel