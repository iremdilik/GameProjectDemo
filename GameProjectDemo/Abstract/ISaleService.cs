using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void GameSale(Gamer gamer, Game game);
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);

    }
}
