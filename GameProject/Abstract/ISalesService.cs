using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game);
        void CampaignSales(Game game, Campaign campaign,Gamer gamer);
    }
}
