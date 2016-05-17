using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Föreläsning10___ValidationExercisee.Models
{
    public class Cake
    {
        [ScaffoldColumn(false)]
        public int CakeID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(1000)]
        public string Summary { get; set; }

        [Required, MaxLength(4000)]
        public string Ingredients { get; set; }

        [Range(1, 180)]
        public int CookingTime { get; set; }

        [Required, MaxLength(4000)]
        public string Instructions { get; set; }


        public virtual List<CakeReview> Reviews { get; set; }

    }
}