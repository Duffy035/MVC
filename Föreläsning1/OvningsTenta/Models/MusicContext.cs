using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OvningsTenta.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicContext() : base("ASPOvningsTentaDB")
        {
            Database.SetInitializer<MusicContext>(new MusicContextInitilazier());   
        }
    }

    internal class MusicContextInitilazier : DropCreateDatabaseAlways<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var artists = new List<Artist>();

            artists.Add(new Artist()
            {
                ArtistId = 1,
                Name = "Freddie Mercury",
                Age = 40,
                Band = "Queen",
                Songs = new List<Song>
                {
                    new Song() { ArtistId = 1, Titel = "Bicycle", Genre = "Rock", Duration = 3.30, Id = 1 },
                    new Song() { ArtistId = 1, Titel = "We are the champions", Genre = "Rock", Duration = 2.50, Id = 2}
                }
            });

            artists.Add(new Artist()
            {
                ArtistId = 2,
                Name = "Axl Rose",
                Age = 54,
                Band = "Guns n Roses",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 2, Titel = "It's So Easy", Genre = "Rock", Duration = 3.45, Id = 1},
                    new Song() {ArtistId = 2, Titel = "Coma", Genre = "Rock", Duration = 8.00, Id = 2}
                }
            });

            artists.Add(new Artist()
            {
                ArtistId = 3,
                Name = "Lisa Ekdahl",
                Age = 45,
                Band = "",
                Songs = new List<Song>
                {
                    new Song() {ArtistId = 3, Titel = "Vem vet", Genre = "Pop", Duration = 3.54, Id = 1},
                    new Song() {ArtistId = 3, Titel = "Tjohej", Genre = "Pop", Duration = 2.31, Id = 2}
                }
            });

            context.Artists.AddRange(artists);
            context.SaveChanges();

        }
    }
}