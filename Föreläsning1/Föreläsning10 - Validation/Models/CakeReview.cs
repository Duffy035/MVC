using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Föreläsning10___Validation.Models
{
    public class CakeReview
    {
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Score { get; set; }
        public int CakeID { get; set; }

        public Cake Cake { get; set; }

    }
}