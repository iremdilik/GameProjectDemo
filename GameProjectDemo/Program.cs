using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "İREM",
                LastName = "DİLİK",
                BirthYear = 2001,
                IdentityNumber = 12345678910
            };

            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            GameManager gameManager = new GameManager();
            Game game1 = new Game
            {
                Name = "LOL",
                Price = 50
            };

            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign
            {
                Name = "Kış İndirimi",
                Percentage = 25
            };

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.CampaignSale(gamer1, game1, campaign1);
            saleManager.GameSale(gamer1, game1);
        }
    }
}
