using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    // Sistemde oyunu satın alabilirim ve böylece hesabıma eklenir. Birde istersem oyunu hesabımdan silebilirim.
    // Aşağıda taslağımı bu şekilde oluşturuyorum.
    interface IGameManager
    {
        void Add(Player player, Game game);
        void Delete(Player player, Game game);
    }
}
