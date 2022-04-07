using Microsoft.EntityFrameworkCore;

namespace Group8_Hobbies.Models
{
    public class AnimeContextModel : DbContext
    {
        public AnimeContextModel(DbContextOptions<AnimeContextModel> options) 
            : base(options) { }
        
        public DbSet<Animation.AnimationModel> Animations { get; set; }
        public DbSet<Animation.PublishModel> Publishes { get; set; }
    }
}
