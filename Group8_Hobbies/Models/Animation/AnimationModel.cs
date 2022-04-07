using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group8_Hobbies.Models.Animation
{
    public class AnimationModel
    {
        public int AnimeId { get; set; }
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public int? WatchingYear { get; set; }
        public int Rate { get; set; }
        public int PublisherId { get; set; }
        public PublishModel Publish { get; set; }
        
    }
}
