using Microsoft.EntityFrameworkCore;

namespace Group8_Hobbies.Models
{
    public class HobbiesContextModel : DbContext
    {
        public HobbiesContextModel(DbContextOptions<HobbiesContextModel> options) 
            : base(options) { }
        
        public DbSet<AnimationModel> Animations { get; set; }
        public DbSet<PublishModel> Publishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimationModel>().HasKey(x => x.AnimeId);
            modelBuilder.Entity<PublishModel>().HasKey(x => x.PublisherId);

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
        }
    }
}
