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
        public DbSet<PublishModel> Publishes { get; set; }
        public DbSet<RunningModel> Races { get; set; }

        public DbSet<SportsModel> Sports { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationModel>().HasKey(x => x.AnimeId);
            modelBuilder.Entity<PublishModel>().HasKey(x => x.PublisherId);
            modelBuilder.Entity<RunningModel>().HasKey(x => x.RunningId);

            modelBuilder.Entity<SportsModel>().HasKey(x => x.SportsModelId);

            modelBuilder.Entity<AnimationModel>().HasData(

                // animation info
                new AnimationModel
                {
                    AnimeId = 1,
                    Name = "Demon Slayer",
                    PublishYear = 2019,
                    WatchingYear = 2020,
                    Rate = 4,
                    PublisherId = 1,
                },
                new AnimationModel
                {
                    AnimeId = 2,
                    Name = "My NeighborTotoro",
                    PublishYear = 1988,
                    WatchingYear = 2007,
                    Rate = 5,
                    PublisherId = 2,
                },
                new AnimationModel
                {
                    AnimeId = 3,
                    Name = "White Cat Legend",
                    PublishYear = 2020,
                    WatchingYear = 2020,
                    Rate = 4,
                    PublisherId = 3,
                }
            );

            // publisher info
            modelBuilder.Entity<PublishModel>().HasData(
              new PublishModel
              {
                  PublisherId = 1,
                  Country = "Japan",
                  Name = "UFOTable"
              },
              new PublishModel
              {
                  PublisherId = 2,
                  Country = "Japan",
                  Name = "Ghibli"
              },
              new PublishModel
              {
                  PublisherId = 3,
                  Country = "China",
                  Name = "Nice Boat Animation Studio"
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
        }
    }
}
