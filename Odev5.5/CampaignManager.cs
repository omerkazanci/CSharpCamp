using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5._5
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
