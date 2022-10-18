using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Abstract
{
    public interface IGameService
    {
        void Add(Games game);
        void Buy(Games game, Customer customer);
        void Sell(Games game);
        void SaleWithCampaign(Customer customer, Games game, Campaigns campaign);
    }
}
