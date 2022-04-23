using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Group8_Hobbies.Models
{
    public class AnimationModel
    {
        [Key]
        public int AnimeId { get; set; }
        [Required(ErrorMessage ="Animation Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Animation Publish Year is required")]
        [Range (1900, 2022, ErrorMessage ="Year Range has to be between 1900 - 2022")]
        public int PublishYear { get; set; }
        
        public int? WatchingYear { get; set; }
        [Required(ErrorMessage = "Animation Publish Year is required")]
        [Range(1, 5, ErrorMessage = "Year Range has to be between 1 - 5")]
        public int Rate { get; set; }

        [Required(ErrorMessage = "Animation Publisher Name is required")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Animation Publish Country is required")]
        public string PublisherCountry { get; set; }

        public string Typo => PublisherName?.Replace(' ', '-') + '-' + PublisherCountry;
    }
}
