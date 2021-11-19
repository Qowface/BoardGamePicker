using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public class GameListViewModel
    {
        public IEnumerable<BoardGame> BoardGames { get; set; } = new List<BoardGame>();
        public string Title { get; set; }
        public int Players { get; set; }
        public int Minutes { get; set; }
    }
}
