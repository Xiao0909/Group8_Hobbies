using Microsoft.EntityFrameworkCore;

namespace Group8_Hobbies.Models
{
    public class AnimeContextModel : DbContext
    {
        public AnimeContextModel(DbContextOptions<AnimeContextModel> options) 
            : base(options) { }
        
        public DbSet<Animation.AnimationModel> Animations { get; set; }
        public DbSet<Animation.PublishModel> Publishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animation.AnimationModel>().HasData(
                // animation info
                new Animation.AnimationModel
                {
                    AnimeId = 1,
                    Name = "Demon Slayer",
                    PublishYear = 2019,
                    WatchingYear = 2020,
                    Rate = 4,
                    PublisherId = 1,
                },
                new Animation.AnimationModel
                {
                    AnimeId = 2,
                    Name = "My NeighborTotoro",
                    PublishYear = 1988,
                    WatchingYear = 2007,
                    Rate = 5,
                    PublisherId = 2,
                },
                new Animation.AnimationModel
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
            modelBuilder.Entity<Animation.PublishModel>().HasData(
              new Animation.PublishModel
              {
                  PublisherId = 1,
                  Country = "Japan",
                  Name = "UFOTable"
              },
              new Animation.PublishModel
              {
                  PublisherId = 2,
                  Country = "Japan",
                  Name = "Ghibli"
              },
              new Animation.PublishModel
              {
                  PublisherId = 3,
                  Country = "China",
                  Name = "Nice Boat Animation Studio"
              }
          );
        }
    }
}
