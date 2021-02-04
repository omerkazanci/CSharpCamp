using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    class GameManager : IGameManager
    {
        public void Add(Player player, Game game)
        {
            Console.WriteLine("{0} oyunu {1} adlı kullanıcının hesabına eklendi", game.Name, player.Name);
        }

        public void Delete(Player player, Game game)
        {
            Console.WriteLine("{0} oyunu {1} adlı kullanıcının hesabından silindi", game.Name, player.Name);

        }
    }
}
