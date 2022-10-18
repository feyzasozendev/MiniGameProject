using MiniGameProject.Abstract;
using MiniGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine("{0} isimli oyun sisteme eklendi.", game.GameName);
        }

        public void Buy(Games game, Customer customer)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından satın alındı.", game.GameName, customer.FirstName + " " + customer.LastName);
        }

        public void SaleWithCampaign(Customer customer, Games game, Campaigns campaign)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından {2} kampanyası dahilinde %{3} indirimle satın alındı.",
               game.GameName, customer.FirstName + " " + customer.LastName, campaign.CampaignName, campaign.DiscountRate * 100);
        }

        public void Sell(Games game)
        {
            Console.WriteLine("Oyun satıldı. Paranız hesabınıza yüklenmiştir..");
        }
    }
}
