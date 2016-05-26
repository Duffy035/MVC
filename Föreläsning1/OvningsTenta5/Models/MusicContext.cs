using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OvningsTenta5.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext() : base("OvningsTenta5.2")
        {
            Database.SetInitializer(new MusicContextInitializer());
        }
    }

    internal class MusicContextInitializer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artists = new List<Artist>();
            artists.Add(new Artist()
            {
                ArtistId = 1,
                Name = "Axl sddsd",
                Age = 54,
                Band = "Guns N Roses",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 1, SongId = 1, Title = "Doasd Cry", Genre = "Rock", Duration = 5.12},
                    new Song() {ArtistId = 1, SongId = 2, Title = "Better", Genre = "Rock", Duration = 3.42}
                }
            });

            artists.Add(new Artist()
            {
                ArtistId = 1,
                Name = "Axl asdasd",
                Age = 54,
                Band = "Guns N Roses",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 2, SongId = 1, Title = "Dry", Genre = "Rock", Duration = 5.12},
                    new Song() {ArtistId = 2, SongId = 2, Title = "Bred", Genre = "Rock", Duration = 3.42}
                }
            });
            artists.Add(new Artist()
            {
                ArtistId = 1,
                Name = "AaRose",
                Age = 54,
                Band = "Gunsasdses",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 3, SongId = 1, Title = "Doy", Genre = "Rock", Duration = 5.12},
                    new Song() {ArtistId = 3, SongId = 2, Title = "Retr", Genre = "Rock", Duration = 3.42}
                }
            });

            context.Artists.AddRange(artists);
            context.SaveChanges();
        }
    }
}
