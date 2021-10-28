using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Minimum Players")]
        public int MinPlayers { get; set; }
        [Display(Name = "Maximum Players")]
        public int MaxPlayers { get; set; }

        [Display(Name = "Length (minutes)")]
        public int Length { get; set; }
    }
}
