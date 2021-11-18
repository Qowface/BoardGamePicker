using BoardGamePicker.Data;
using BoardGamePicker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BoardGamePickerContext _bgContext;

        public HomeController(ILogger<HomeController> logger, BoardGamePickerContext bgContext)
        {
            _logger = logger;
            _bgContext = bgContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Results(int players, int minutes)
        {
            var boardGames = _bgContext.BoardGame
                    .Where(bg => players >= bg.MinPlayers)
                    .Where(bg => players <= bg.MaxPlayers)
                    .Where(bg => minutes >= bg.Length);

            return View(await boardGames.ToListAsync());
        }

        public async Task<IActionResult> Random(int players, int minutes)
        {
            var boardGames = _bgContext.BoardGame
                    .Where(bg => players >= bg.MinPlayers)
                    .Where(bg => players <= bg.MaxPlayers)
                    .Where(bg => minutes >= bg.Length);

            var randomGame = await boardGames
                    .OrderBy(r => Guid.NewGuid())
                    .FirstOrDefaultAsync();

            return View(new GameSearchViewModel {
                BoardGame = randomGame,
                Players = players,
                Minutes = minutes
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
