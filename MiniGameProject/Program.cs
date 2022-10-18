using MiniGameProject.Adapters;
using MiniGameProject.Concrete;
using MiniGameProject.Entities;
using System;

namespace MiniGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());

            GameManager gameManager = new GameManager();

            CampaignManager campaignManager = new CampaignManager();

            Customer customer1 = new Customer { DateOfBirth = new DateTime(1997, 8, 23), FirstName = "Feyza", LastName = "Sözen", Id = 1, NationalityId = "121212121212" };

            customerManager.Add(customer1);

            Games game1 = new Games() { Id = 1, GameName = "Gta V", GamePrice = 75 };

            gameManager.Add(game1);

            gameManager.Buy(game1, customer1);

            Campaigns campaign1 = new Campaigns() { Id = 1, CampaignName = "Yılbaşı Özel", DiscountRate = 0.1f };

            gameManager.SaleWithCampaign(customer1, game1, campaign1);



            Console.ReadKey();
        }
    }
}
