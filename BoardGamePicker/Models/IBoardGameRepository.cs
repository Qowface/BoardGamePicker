using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public interface IBoardGameRepository
    {
        Task<IEnumerable<BoardGame>> FilteredBoardGamesAsync(string title, int players, int minutes);
        Task<BoardGame> RandomBoardGameAsync(int players, int minutes);
    }
}
