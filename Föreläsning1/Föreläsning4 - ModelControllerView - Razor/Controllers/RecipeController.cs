using Föreläsning4___ModelControllerView___Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Föreläsning4___ModelControllerView___Razor.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult FullDetails()
        {
            var recipe = new RecipeDetailsModel
            {
                Name = "Tigerkaka",
                Ingredients = "2 ägg, 3 dl socker, 3 dl vetemjöl, 1 tsk bakpulver, 1 tsk, vaniljsocker, 1 msk kakao, 150 g smör",
                CookingTime = 35,
                Instructions = "Baka den",
                Difficulty = 2
            };
            return View(recipe);
        }
    }
}