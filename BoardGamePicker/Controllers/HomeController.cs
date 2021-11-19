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
        private readonly IBoardGameRepository _bgRepository;

        public HomeController(ILogger<HomeController> logger, IBoardGameRepository bgRepository)
        {
            _logger = logger;
            _bgRepository = bgRepository;
        }

        public IActionResult Index()
        {
            return View(new GamePickerViewModel
            {
                BoardGame = null,
                Players = 0,
                Minutes = 0
            });
        }

        public async Task<IActionResult> Random(int players, int minutes)
        {
            var randomGame = await _bgRepository.RandomBoardGameAsync(players, minutes);
            
            return View(new GamePickerViewModel {
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
