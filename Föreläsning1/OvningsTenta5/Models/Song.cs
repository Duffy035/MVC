using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OvningsTenta5.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }

    }
}