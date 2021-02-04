using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    interface IPlayerManager
    {
        void Register(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
