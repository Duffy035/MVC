using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta3.Models
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }
        [Required, CustomAttribute.CustomCheckAttribute]
        public string Titel { get; set; }
        [Required, /*MinLength(1), MaxLength(ErrorMessage = "Use a valid lenght")*/]
        public double Duration { get; set; }
        [Required, Editable(true)]
        public string Genre { get; set; }
        [Required, ScaffoldColumn(false)]
        public int ArtistId { get; set; }

    }
}