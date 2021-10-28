using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int Length { get; set; }
    }
}
