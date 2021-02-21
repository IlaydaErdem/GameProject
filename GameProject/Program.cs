using GameProject.Adapters;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        private static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            
            gamer1.Id = 1;
            gamer1.FirstName = "İlayda";
            gamer1.LastName = "Erdem";
            gamer1.NationalityId = "18001596392";
            gamer1.DateOfBirth = new DateTime(1998, 6, 24);

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            bool isValid = gamerCheckManager.CheckIfRealPerson(gamer1);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Need For Speed";
            game1.GamePrice = 500;
            game1.GameSaleDate = new DateTime(2021, 8, 2);

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "Öğrenci'ye Özel Kampanya",
                DiscountRate = 10

            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 2,
                CampaignName = "Covid-19'a Özel Kampanya ",
                DiscountRate = 10
            };

            Campaign campaign3 = new Campaign()
            {
                CampaignId = 3,
                CampaignName = "Yeni Kayıt Kampanyası",
                DiscountRate = 10
            };

            
            if (isValid )
            {
                GamerManager gamerManager = new GamerManager();
                gamerManager.Add(gamer1);
                Console.WriteLine("Gerçek Kullanıcı " /*+ gamer1.FirstName + " " + gamer1.LastName*/);
                Console.WriteLine("Alınan Oyunlar : " + game1.GameName + " ----> " + "Oyun Fiyatı : " + game1.GamePrice + "TL" );
                Console.WriteLine("Ugulanan İndirimler : " + campaign1.CampaignName + " + " + campaign2.CampaignName + " + " + campaign3.CampaignName );
                
            }
            
            else
            {
                Console.WriteLine("Gerçek Kullanıcı Değil !!");
                Console.WriteLine("Bigileri Yanlış ");
                Console.ReadLine();
            }
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign3);
            campaignManager.Update(campaign2);
            SalesManager salesManager = new SalesManager();
            salesManager.CampaignSales(game1, campaign1 ,gamer1);
            Console.ReadLine();
        }
    }
}
