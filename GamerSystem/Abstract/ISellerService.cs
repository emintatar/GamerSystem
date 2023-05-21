using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerSystem.Abstract
{
    public interface ISellerService
    {
        void BuyGame(Gamer gamer, Game game);
        void SellGame(Gamer gamer, Game game);
        void SellGameWithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
