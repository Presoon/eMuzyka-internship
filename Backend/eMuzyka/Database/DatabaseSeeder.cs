using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzyka.Domain.Entities;

namespace eMuzyka.Database
{
    public class DatabaseSeeder
    {
        private readonly DatabaseContext _dbContext;

        public DatabaseSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (!_dbContext.Database.CanConnect()) return;
            if (_dbContext.Providers.Any()) return;
            _dbContext.Providers.AddRange(GetProviders());
            _dbContext.SaveChanges();
        }

        private static IEnumerable<Provider> GetProviders()
        {
            var providers = new List<Provider>()
            {
                new Provider()
                {
                    Name = "Kamil",
                    LastName = "Szpak",
                    Email = "kamilszpak99@gmail.com",
                    UserName = "seev",
                    Password = "abdc",
                    CreatedAt = DateTime.Now,
                    Albums = new List<Album>()
                    {
                        new Album()
                        {
                            ArtistName = "Pink Floyd",
                            Title = "The Dark Side of the Moon",
                            ReleaseDate = new DateTime(1973, 3, 1),
                            Version = "Standard",
                            Tracks = new List<Track>()
                            {
                                new Track()
                                {
                                    TrackNumber = 1,
                                    Title = "Speak to Me/Breathe",
                                    ArtistName = "Pink Floyd",
                                    Duration = 237,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 2,
                                    Title = "On the Run",
                                    ArtistName = "Pink Floyd",
                                    Duration = 230,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 3,
                                    Title = "Time",
                                    ArtistName = "Pink Floyd",
                                    Duration = 409,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 4,
                                    Title = "The Great Gig in the Sky",
                                    ArtistName = "Pink Floyd",
                                    Duration = 284,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 5,
                                    Title = "Money",
                                    ArtistName = "Pink Floyd",
                                    Duration = 382,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 6,
                                    Title = "Us and Them",
                                    ArtistName = "Pink Floyd",
                                    Duration = 469,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 7,
                                    Title = "Any Colour You Like",
                                    ArtistName = "Pink Floyd",
                                    Duration = 206,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 8,
                                    Title = "Brain Damage",
                                    ArtistName = "Pink Floyd",
                                    Duration = 226,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                },
                                new Track()
                                {
                                    TrackNumber = 9,
                                    Title = "Eclipse",
                                    ArtistName = "Pink Floyd",
                                    Duration = 131,
                                    ReleaseDate = new DateTime(1973, 3,1)
                                }
                            }
                        }
                    }
                }
            };

            return providers;
        }
    }
}
