using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    class PlayerManager : IPlayerManager
    {
        /// Bu kısmı anlamakta zorluk çeken arkadaşlarımız vardır diye düşünüyorum. Kendimce açıklamaya çalışayım.
        /// 
        IUserValidationManager _userValidationManager;

        public PlayerManager(IUserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }
        

        public void Register(Player player)
        {
            if (_userValidationManager.Validate(player))
            {
                Console.WriteLine("Oyuncu kaydedildi...");
            }
            else
            {
                Console.WriteLine("Böyle bir vatandaş kaydı bulunamadı. Kayıt başarısız.");
            }
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi...");
        }


        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi...");
        }
    }
}
