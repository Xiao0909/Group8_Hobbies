using Group8_Hobbies.Models.Games;
using Group8_Hobbies.Models.Sports;
using Microsoft.EntityFrameworkCore;
using System;

namespace Group8_Hobbies.Models
{
    public class HobbiesContextModel : DbContext
    {
        public HobbiesContextModel(DbContextOptions<HobbiesContextModel> options) 
            : base(options) { }
        
        public DbSet<AnimationModel> Animations { get; set; }

        public DbSet<SportsModel> Sports { get; set; } 
        public DbSet<RunningModel> Races { get; set; }

        public DbSet<GamesModel> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationModel>().HasKey(x => x.AnimeId);

            modelBuilder.Entity<SportsModel>().HasKey(x => x.SportsModelId);
            modelBuilder.Entity<RunningModel>().HasKey(x => x.RunningId);
            modelBuilder.Entity<GamesModel>().HasKey(x => x.GamesModelID);

            modelBuilder.Entity<AnimationModel>().HasData(

                // animation info
                new AnimationModel
                {
                    AnimeId = 1,
                    Name = "Demon Slayer",
                    PublishYear = 2019,
                    WatchingYear = 2020,
                    Rate = 4,
                    PublisherName ="UFOTable",
                    PublisherCountry = "Japan",
                },
                new AnimationModel
                {
                    AnimeId = 2,
                    Name = "My NeighborTotoro",
                    PublishYear = 1988,
                    WatchingYear = 2007,
                    Rate = 5,
                    PublisherCountry="Japan",
                    PublisherName="Ghibli"
                },
                new AnimationModel
                {
                    AnimeId = 3,
                    Name = "White Cat Legend",
                    PublishYear = 2020,
                    WatchingYear = 2020,
                    Rate = 4,
                    PublisherName = "Nice Boat Animation Studio",
                    PublisherCountry="China"
                }
            );

            //Sports info
            modelBuilder.Entity<SportsModel>().HasData(
                new SportsModel
                {
                    SportsModelId = 1,
                    SportsName = "Basketball",
                    SportsDescription = "A sport where you score the ball into a basket 10 feet high from the ground",
                    TeamName = "Golden State Warriors",
                    TeamWins = 53,
                    TeamLosses = 29
                },
                new SportsModel
                {
                    SportsModelId = 2,
                    SportsName = "Basketball",
                    SportsDescription = "A sport where you score the ball into a basket 10 feet high from the ground",
                    TeamName = "Phoenix Suns",
                    TeamWins = 64,
                    TeamLosses = 18
                },
                new SportsModel
                {
                    SportsModelId = 3,
                    SportsName = "Basketball",
                    SportsDescription = "A sport where you score the ball into a basket 10 feet high from the ground",
                    TeamName = "Memphis Grizzlies",
                    TeamWins = 56,
                    TeamLosses = 26
                },
                new SportsModel
                {
                    SportsModelId = 4,
                    SportsName = "Soccer",
                    SportsDescription = "A sport where you score the ball into a post with your foot",
                    TeamName = "Manchester City",
                    TeamWins = 24,
                    TeamLosses = 3
                },
                new SportsModel
                {
                    SportsModelId = 5,
                    SportsName = "Soccer",
                    SportsDescription = "A sport where you score the ball into a post with your foot",
                    TeamName = "Liverpool",
                    TeamWins = 23,
                    TeamLosses = 2
                }

            );

            // running races info
            modelBuilder.Entity<RunningModel>().HasData(
              new RunningModel
              {
                  RunningId = 1,
                  Name = "Cincinnati Flying Pig",
                  Distance = 26.2,
                  Date = DateTime.Parse("05/01/2022"),
                  Website = "https://flyingpigmarathon.com"
              },
              new RunningModel
              {
                  RunningId = 2,
                  Name = "Cleveland Turkey Trot",
                  Distance = 3.1,
                  Date = DateTime.Parse("11/24/2022"),
                  Website = "https://www.turkeytrotcleveland.com"
              },
              new RunningModel
              {
                  RunningId = 3,
                  Name = "Boston Marathon",
                  Distance = 26.2,
                  Date = DateTime.Parse("04/18/2022"),
                  Website = "https://www.baa.org"
              },
              new RunningModel
              {
                  RunningId = 4,
                  Name = "Bolder Boulder 10k",
                  Distance = 6.2,
                  Date = DateTime.Parse("05/30/2022"),
                  Website = "https://www.bolderboulder.com"
              },
              new RunningModel
              {
                  RunningId = 5,
                  Name = "Chicago Marathon",
                  Distance = 26.2,
                  Date = DateTime.Parse("08/09/2022"),
                  Website = "https://www.chicagomarathon.com"
              }
          );

            modelBuilder.Entity<GamesModel>().HasData(
                new GamesModel


                //    { 9, "Sekiro: Shadows Die Twice", "Acction/Hack & Slash", "PS4/PS5/PC/XBox 1/XBox Series S/X", "Bandai Namco", 9 },
                //    { 10, "Destiny 2", "First Person Shooter", "PS4/PS5/PC/XBox 1/XBox Series S/X", "Activision/Bungie", 7 }
                {
                    GamesModelID = 1,
                    GameName = "Horizon: Zero Dawn",
                    GameGenre = "Open world Adventure/Action Role Playing Game",
                    AvailablePlatform = "PS4/PS5/PC",
                    GamePublisher = "Sony Interactive Entertainment",
                    PersonalRating = 9
                },
                new GamesModel
                {
                    GamesModelID = 2,
                    GameName = "Ghost of Tsushima",
                    GameGenre = "Open world Adventure/Action Role Playing Game",
                    AvailablePlatform = "PS4/PS5",
                    GamePublisher = "Sony Interactive Entertainment",
                    PersonalRating = 10
                },
                new GamesModel
                {
                    GamesModelID = 3,
                    GameName = "Elden Ring",
                    GameGenre = "Open world Adventure/Action Role Playing Game",
                    AvailablePlatform = "PS4/PS5/PC/XBox 1/XBox Series S/X",
                    GamePublisher = "Bandai Namco",
                    PersonalRating = 10
                },
                new GamesModel
                {
                    GamesModelID = 4,
                    GameName = "Warframe",
                    GameGenre = "Open world Adventure/Action Role Playing Game",
                    AvailablePlatform = "All",
                    GamePublisher = "Digital Extremes",
                    PersonalRating = 8
                },
                new GamesModel
                {
                    GamesModelID = 5,
                    GameName = "Control",
                    GameGenre = "Action/Adventure",
                    AvailablePlatform = "All",
                    GamePublisher = "505 Games",
                    PersonalRating = 9
                },
                new GamesModel
                {
                    GamesModelID = 6,
                    GameName = "Sifu",
                    GameGenre = "Action",
                    AvailablePlatform = "PS4/PS5/PC",
                    GamePublisher = "Sloclap",
                    PersonalRating = 7
                },
                new GamesModel
                {
                    GamesModelID = 7,
                    GameName = "God of War(2018)",
                    GameGenre = "Action/Adventture",
                    AvailablePlatform = "PS4/PS5/PC",
                    GamePublisher = "Sony Interactive Entertainment",
                    PersonalRating = 9
                },
                new GamesModel
                {
                    GamesModelID = 8,
                    GameName = "Little Nightmares",
                    GameGenre = "Puzzle/Platformer/Horror",
                    AvailablePlatform = "All",
                    GamePublisher = "Bandai Namco",
                    PersonalRating = 8
                },
                new GamesModel
                {
                    GamesModelID = 9,
                    GameName = "Sekiro: Shadows Die Twice",
                    GameGenre = "Action/Hack & Slash",
                    AvailablePlatform = "PS4/PS5/PC/XBox 1/XBox Series S/X",
                    GamePublisher = "Bandai Namco",
                    PersonalRating = 9
                },
                new GamesModel
                {
                    GamesModelID = 10,
                    GameName = "Destiny 2",
                    GameGenre = "First Person Shooter/MMO",
                    AvailablePlatform = "PS4/PS5/PC/XBox 1/XBox Series S/X",
                    GamePublisher = "Activision/Bungie",
                    PersonalRating = 7
                }
            );

        }
    }
}
