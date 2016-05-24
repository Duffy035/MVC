using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OvningsTenta.Models
{
    public class Artist
    {
        [Required]
        public int ArtistId { get; set; }
        [Required, CheckArtistAttribute]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required, CheckArtistAttribute]
        public string Band { get; set; }
        public List<Song> Songs { get; set; }
    }

    public class CheckArtistAttribute : ValidationAttribute
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
            //return $"Please don't use the following words: {field}";
        }
    }
}