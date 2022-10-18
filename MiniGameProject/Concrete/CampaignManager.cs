using MiniGameProject.Abstract;
using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine("{0} isimli kampanya sisteme tanımlandı.", campaign.CampaignName);
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine("{0} isimli kampanyada sistemden silindi.", campaign.CampaignName);
        }

        public void MakeDiscount(Games game, Campaigns campaign)
        {
            Console.WriteLine("{0} isimli oyuna {1} kampanyası tanımlandı.", game.GameName, campaign.CampaignName);
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine("{0} isimli kampanyada güncelleme yapıldı.", campaign.CampaignName);
        }
    }
}
