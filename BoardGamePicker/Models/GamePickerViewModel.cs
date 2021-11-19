using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGamePicker.Models
{
    public class GamePickerViewModel
    {
        public BoardGame BoardGame { get; set; }
        public int Players { get; set; }
        public int Minutes { get; set; }
    }
}
