using System;
using System.Collections.Generic;
using System.Text;

namespace _101Simulate
{
    class ChipManager : IChipService
    {
        public void Buy(Player player, Chip chip)
        {
            Console.WriteLine(player.NickName + " " + chip.ChipPrice + " TL'ye " + chip.ChipUnit + " çip aldı.");
        }
    }
}
