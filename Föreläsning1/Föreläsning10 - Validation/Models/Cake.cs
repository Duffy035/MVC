﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Föreläsning10___Validation.Models
{
    public class Cake
    {
        
        public int CakeID { get; set; }

        [Required, Range(100, 1000)]
        public string Name { get; set; }

        [Required, Range(100, 1000)]
        public string Summary { get; set; }

        [Required, MaxLength(4000)]
        public string Ingredients { get; set; }

        [Range(1,180)]
        public int CookingTime { get; set; }

        [Required, MaxLength(4000)]
        public string Instructions { get; set; }

        public virtual List<Cake> Reviews { get; set; }

    }
}