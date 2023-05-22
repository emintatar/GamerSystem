using GamerSystem.Abstract;
using GamerSystem.Concrete;
using GamerSystem.Entities;
using System;

namespace GamerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Register(new Gamer
            {
                Id = 1,
                FirstName = "Emin",
                LastName = "Tatar",
                DateOfBirth = new DateTime(2002, 4, 6),
                NationalityId = "123456789"
            });

            ISellerService sellerManager = new SellerManager(new CampaignManager());
            sellerManager.SellGameWithCampaign(new Gamer 
            {
                Id = 1,
                FirstName = "Emin",
                LastName = "Tatar",
                DateOfBirth = new DateTime(2002, 4, 6),
                NationalityId = "123456789"
            }, 
            new Game 
            {
                Id = 1,
                GameName = "GTA V",
                GamePrice = 100
            }, 
            new Campaign 
            {
                Id = 1,
                CampaignName = "Black Friday",
                DiscountRate = 50
            });
        }
    }
}
