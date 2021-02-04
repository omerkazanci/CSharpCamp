using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    class GameSalesManager : IGameSalesManager
    {
        public void Buy(Player player, Game game)
        {
            Console.WriteLine("{0} adlı kullanıcı {1} oyununu satın aldı", player.Name, game.Name);
        }
    }
}
