using System;

namespace Odev5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sisteme giriş yapıyorum
            Player player = new Player { Name = "Ömer", Surname = "Kazancı", DateBirth = 1995, NationalityId = 123456 };
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Register(player);


            // Sistemde bir oyun satın alıyorum
            GameSalesManager gameSalesManager = new GameSalesManager();
            Game game = new Game { Id = 1, Name = "GTA5", Price = 35 };
            gameSalesManager.Buy(player, game);


            // Satın aldığım oyunu hesabıma ekliyorum
            GameManager gameManager = new GameManager();
            gameManager.Add(player, game);



        }
    }
}
