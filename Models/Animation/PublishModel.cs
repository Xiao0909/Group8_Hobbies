using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group8_Hobbies.Models
{
    public class PublishModel
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }
        public string Typo => Name?.Replace(' ', '-').ToLower() + '-' + Country;
    }
}
