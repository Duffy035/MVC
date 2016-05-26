using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta4.Models
{
    public class Song
    {
        [Required, ScaffoldColumn(false)]
        public int SongId { get; set; }
        [Required, CustomAttribute.CustomAttributeChecker]
        public string Title { get; set; }
        [Required]
        public double Duration { get; set; }
        [Required, CustomAttribute.CustomAttributeChecker]
        public string Genre { get; set; }
        [Required, ScaffoldColumn(false)]
        public int  ArtistId { get; set; }

    }
}