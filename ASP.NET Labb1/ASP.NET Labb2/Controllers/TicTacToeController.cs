using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Labb2.Models;

namespace ASP.NET_Labb2.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
        public ActionResult Index()
        {
            TicTacToeModel.ResetTile();
            return View();
        }

        [HttpPost]
        public ActionResult index(string send)
        {
            try
            {
                if (send == "Reset Game")
                {
                    TicTacToeModel.ResetTile();
                }
                else
                {
                    ViewBag.Message = TicTacToeModel.RunGameLogic(send);
                }
                return View();
            }
            catch (Exception e)
            {
                ViewBag.Message = "Choose an empty space";
                return View();
            }

        }
    }
}