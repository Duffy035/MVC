using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Föreläsning4___ModelControllerView___Razor.Models
{
    public class RecipeDetailsModel  //Vår egna model
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public int CookingTime { get; set; }
        public string Instructions { get; set; }
        public int Difficulty { get; set; }

    }
}