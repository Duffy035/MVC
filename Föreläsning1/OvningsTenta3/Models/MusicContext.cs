using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OvningsTenta3.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public MusicContext() : base("OvningsTenta3")
        {
            Database.SetInitializer(new MusicContextInitializer());
        }

    }

    internal class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artist = new List<Artist>();

            artist.Add(new Artist()
            {
                ArtistId = 1, Name = "Madonna", Age = 50, Band = "", Songs = new List<Song>()
                {
                    new Song() {SongId = 1, Titel = "Like a virgin", Duration = 4.55, Genre = "Pop", ArtistId = 1},
                    new Song() {SongId = 2, Titel = "Vouge", Duration = 4.00, Genre = "Pop", ArtistId = 1}
                }
            });
            artist.Add(new Artist()
            {
                ArtistId = 2, Name = "Alice Cooper", Age = 74, Band = "", Songs = new List<Song>()
                {
                    new Song() {SongId = 1, Titel = "Poison", Duration = 5.00, Genre = "Rock", ArtistId = 2},
                    new Song() {SongId = 2, Titel = "Bang a rang", Duration = 3.33, Genre = "Rock", ArtistId = 2}
                }
            });
            artist.Add(new Artist()
            {
                ArtistId = 3, Name = "David Bowie", Age = null, Band = "", Songs = new List<Song>()
                {
                    new Song() {ArtistId = 3, Titel = "Station to Station", Duration = 5.45, Genre = "Rock", SongId = 1},
                    new Song() {ArtistId = 3, Titel = "Word on a wing", Genre = "Rock", Duration = 5.00, SongId = 2}
                }
            });
            context.Artists.AddRange(artist);
            context.SaveChanges();
        }
    }
}