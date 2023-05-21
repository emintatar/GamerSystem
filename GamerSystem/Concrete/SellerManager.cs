using GamerSystem.Abstract;
using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystem.Concrete
{
    public class SellerManager : ISellerService
    {
        ICampaignService _campaignService;

        public SellerManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void SellGame(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " sold the " + game.GameName + " game.");
        }
        public void SellGameWithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            _campaignService.AddCampaign(campaign);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " sold the " + game.GameName + " game with " + campaign.CampaignName + " campaign.");
        }

        public void BuyGame(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " bought the " + game.GameName + " game.");
        }
    }
}
