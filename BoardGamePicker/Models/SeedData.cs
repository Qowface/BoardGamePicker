using BoardGamePicker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BoardGamePicker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardGamePickerContext(serviceProvider.GetRequiredService<DbContextOptions<BoardGamePickerContext>>()))
            {
                if (context.BoardGame.Any()) return;

                context.BoardGame.AddRange(
                    new BoardGame
                    {
                        Title = "Exploding Kittens",
                        MinPlayers = 2,
                        MaxPlayers = 5,
                        Length = 15
                    },
                    new BoardGame
                    {
                        Title = "Forbidden Island",
                        MinPlayers = 2,
                        MaxPlayers = 4,
                        Length = 30
                    },
                    new BoardGame
                    {
                        Title = "Codenames",
                        MinPlayers = 2,
                        MaxPlayers = 8,
                        Length = 15
                    },
                    new BoardGame
                    {
                        Title = "Unstable Unicorns",
                        MinPlayers = 2,
                        MaxPlayers = 8,
                        Length = 45
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
