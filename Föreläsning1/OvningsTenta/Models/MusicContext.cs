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

        private class MusicContextInitilazier : DropCreateDatabaseAlways<MusicContext>
        {
            protected override void Seed(MusicContext db)
            {
                DBData(db);
            }

            private void DBData(MusicContext db)
            {

                Artist artist1 = new Artist()
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
                };

                Artist artist2 = new Artist()
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
                };

                Artist artist3 = new Artist()
                {
                    ArtistId = 3,
                    Name = "Lisa Ekdahl",
                    Age = 45,
                    Band = "",
                    Songs = new List<Song>
                {
                    new Song() {ArtistId = 3, Titel = "Vem vet", Genre = "Pop", Duration = 3.54, Id = 1},
                    new Song() {ArtistId = 3, Titel = "Räckor", Genre = "Pop", Duration = 2.31, Id = 2}
                }
                };


                db.Artists.Add(artist1);
                db.Artists.Add(artist2);
                db.Artists.Add(artist3);
                db.SaveChanges();

                //Artist artists = new List<Artist>()
                //{
                //    new Artist() {ArtistId = 1, Name = "Freddie Mercury", Age = 40, Band = "Queen", Songs = new List<Song>
                //    {
                //        new Song()
                //        {
                //            ArtistId = 1, Titel = "Bicycle", Genre = "Rock", Duration = 3.30, Id = 1
                //        },
                //        new Song()
                //        {
                //            ArtistId = 1, Titel = "We are the champions", Genre = "Rock", Duration = 2.50, Id = 2
                //        }
                //    }
                //},
                //    new Artist() {ArtistId = 2, Name = "Axl Rose", Age = 54, Band = "Guns n Roses", Songs = new List<Song>
                //    {
                //        new Song()
                //        {
                //            ArtistId = 2, Titel = "Its So Easy", Genre = "Rock", Duration = 4.00, Id = 1
                //        },
                //        new Song()
                //        {
                //            ArtistId = 2, Titel = "Coma", Genre = "Rock", Duration = 8.00, Id = 2
                //        }
                //    }
                // },
                //    new Artist() {ArtistId = 3, Name = "Philip Anselmo", Age = 49, Band = "Pantera", Songs = new List<Song>
                //    {
                //        new Song()
                //        {
                //            ArtistId = 3, Titel = "Becoming", Genre = "Metal", Duration = 4.50, Id = 1
                //        },
                //        new Song()
                //        {
                //            ArtistId = 3, Titel = "Walk", Genre = "Metal", Duration = 4.00, Id = 2
                //        }
                //    } }


            }
        }
    }
}