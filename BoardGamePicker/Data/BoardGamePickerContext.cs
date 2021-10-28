using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoardGamePicker.Models;

namespace BoardGamePicker.Data
{
    public class BoardGamePickerContext : DbContext
    {
        public BoardGamePickerContext (DbContextOptions<BoardGamePickerContext> options)
            : base(options)
        {
        }

        public DbSet<BoardGamePicker.Models.BoardGame> BoardGame { get; set; }
    }
}
