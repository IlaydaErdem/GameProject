using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class SalesManager : ISalesService
    {

        public void CampaignSales(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Üyemiz : " + gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " ile " + game.GameName + " Oyununu Almıştır");
        }

        public void Sales(Game game)
        {
            
        }
    }
}
