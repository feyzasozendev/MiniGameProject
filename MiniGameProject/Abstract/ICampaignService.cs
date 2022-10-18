using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign);
        void Update(Campaigns campaign);
        void Delete(Campaigns campaign);
        void MakeDiscount(Games game, Campaigns campaign);
    }
}
