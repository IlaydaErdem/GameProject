using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaign.CampaignName + " İndirim Oranı : " + campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.CampaignName);
        }

        
    }
}
