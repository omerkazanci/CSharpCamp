using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    class UserValidationManager : IUserValidationManager
    {

        // Burada e-devlet sisteminde kayıtlı olan kişileri simüle ettim. Bu kayıtlar üzerinden giriş yapacağız.
        List<Player> _players = new List<Player>()
        {
            new Player{Id = 1, Name = "Ömer", Surname = "Kazancı", DateBirth = 1995, NationalityId = 123456},
            new Player{Id = 2, Name = "Engin", Surname = "Demiroğ", DateBirth = 1985, NationalityId = 123456},
            new Player{Id = 3, Name = "Murat", Surname = "Kurtboğan", DateBirth = 1990, NationalityId = 123456},
            new Player{Id = 4, Name = "Kerem", Surname = "Varlık", DateBirth = 1988, NationalityId = 123456},
            new Player{Id = 5, Name = "Eyüp", Surname = "Sabri", DateBirth = 1900, NationalityId = 123456}
        };

        public bool Validate(Player player)
        {
            foreach (Player _player in _players)
            {
                if (_player.Name == player.Name && _player.Surname == player.Surname && _player.NationalityId == player.NationalityId)
                {
                    return true;                    
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
