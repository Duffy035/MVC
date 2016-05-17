using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Föreläsning10___ValidationExercisee.Models
{
    public class CakeReview
    {
        [Required]
        [ScaffoldColumn(false)]
        public int CakeReviewID { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(1000)]
        public string Summary { get; set; }
        [Required, Range(1,10)]
        public int Score { get; set; }
        [Required]

        [ScaffoldColumn(false)]
        public int CakeID { get; set; }

        public Cake Cake { get; set; }

    }
}