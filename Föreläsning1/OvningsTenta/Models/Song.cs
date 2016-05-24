using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OvningsTenta.Models
{
    public class Song
    {
        [Required]
        public int Id { get; set; }
        [Required, CheckAttributeSongs]
        public string Titel { get; set; }
        [Required]
        public double Duration { get; set; }
        [Required, CheckAttributeSongs]
        public string Genre { get; set; }
        [Required]
        public int ArtistId { get; set; }
    }

    public class CheckAttributeSongs : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            var toCheck = value.ToString().ToLower();
            return !toCheck.Contains("gun") && !toCheck.Contains("knife") && !toCheck.Contains("fight");
        }

        public override string FormatErrorMessage(string field)
        {
            return "Please don't use the following words: gun, knife or fight";
        }
    }
}