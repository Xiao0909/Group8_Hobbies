using Microsoft.AspNetCore.Mvc;
using System;

namespace Group8_Hobbies.Models
{
    public class RunningModel
    {
        public int RunningId { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public DateTime Date { get; set; }
        public string Website { get; set; }
    }
}