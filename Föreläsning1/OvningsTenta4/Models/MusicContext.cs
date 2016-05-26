using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OvningsTenta4.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public MusicContext() : base("Ovningstenta4")
        {
            Database.SetInitializer(new MusicContextInitilaizer());
        }
    }

    internal class MusicContextInitilaizer : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artist = new List<Artist>();
            artist.Add(new Artist()
            {
                ArtistId = 1,
                Name = "Axl Rose",
                Age = 54,
                Band = "Guns N Roses",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 1, SongId = 1, Title = "Dont Cry", Genre = "Rock", Duration = 5.12},
                    new Song() {ArtistId = 1, SongId = 2, Title = "Better", Genre = "Rock", Duration = 3.42}
                }
            });

            artist.Add(new Artist()
            {
                ArtistId = 2, Name = "James Hetfield", Band = "Metallica", Age = 56, Songs = new List<Song>
                {
                    new Song() {ArtistId = 2, SongId = 1, Title = "Ride the Lightning", Genre = "Metal", Duration = 6.55},
                    new Song() {ArtistId = 2, SongId = 2, Title = "Master of Puppets", Genre = "Metal", Duration = 4.31}
                }
            });
            artist.Add(new Artist()
            {
                ArtistId = 3, Name = "John Lennon", Age = 76, Band = "The Beatles", Songs = new List<Song>
                {
                    new Song() {ArtistId = 3, SongId = 1, Title = "Imagine", Genre = "Rock/Pop", Duration = 5.01},
                    new Song() {ArtistId = 3, SongId = 2, Title = "Rock n rolla", Genre = "Pop/Rock", Duration = 3.30}

                }
            });

            context.Artists.AddRange(artist);
            context.SaveChanges();
        }
    }
}