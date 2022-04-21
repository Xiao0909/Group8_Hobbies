using Group8_Hobbies.Models.Sports;
using Microsoft.EntityFrameworkCore;

namespace Group8_Hobbies.Models
{
    public class HobbiesContextModel : DbContext
    {
        public HobbiesContextModel(DbContextOptions<HobbiesContextModel> options) 
            : base(options) { }
        
        public DbSet<AnimationModel> Animations { get; set; }
        public DbSet<PublishModel> Publishes { get; set; }

        public DbSet<SportsModel> Sports { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationModel>().HasKey(x => x.AnimeId);
            modelBuilder.Entity<PublishModel>().HasKey(x => x.PublisherId);

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
