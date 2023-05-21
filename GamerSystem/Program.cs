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
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Emin";
            gamer.LastName = "Tatar";
            gamer.DateOfBirth = new DateTime(1999, 1, 1);
            gamer.NationalityId = "12345678910";

            Game game = new Game();
            game.Id = 1;
            game.GameName = "GTA V";
            game.GamePrice = 100;

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Black Friday";
            campaign.DiscountRate = 50;

            IGamerService gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Register(gamer);
            gamerManager.UpdateGamer(gamer);
            gamerManager.DeleteGamer(gamer);

            ISellerService sellerManager = new SellerManager(new CampaignManager());
            sellerManager.SellGameWithCampaign(gamer, game, campaign);
        }
    }
}
