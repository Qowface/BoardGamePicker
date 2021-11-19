using BoardGamePicker.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public class BoardGameRepository : IBoardGameRepository
    {
        private readonly BoardGamePickerContext _bgContext;

        public BoardGameRepository(BoardGamePickerContext bgContext)
        {
            _bgContext = bgContext;
        }

        public async Task<IEnumerable<BoardGame>> FilteredBoardGamesAsync(string title, int players, int minutes)
        {
            var boardGames = from bg in _bgContext.BoardGame select bg;

            if (!String.IsNullOrEmpty(title))
            {
                boardGames = boardGames.Where(bg => bg.Title.Contains(title));
            }
            if (players != 0)
            {
                boardGames = boardGames.Where(bg => players >= bg.MinPlayers).Where(bg => players <= bg.MaxPlayers);
            }
            if (minutes != 0)
            {
                boardGames = boardGames.Where(bg => minutes >= bg.Length);
            }

            return await boardGames.ToListAsync();
        }

        public async Task<BoardGame> RandomBoardGameAsync(int players, int minutes)
        {
            var boardGames = await FilteredBoardGamesAsync(null, players, minutes);

            return boardGames
                .OrderBy(r => Guid.NewGuid())
                .FirstOrDefault();
        }
    }
}
