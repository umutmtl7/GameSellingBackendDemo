using System;
using GameSellingBackendDemo.Adapters;
using GameSellingBackendDemo.Concrete;
using GameSellingBackendDemo.Entities;
using System.Collections.Generic;
namespace GameSellingBackendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> _myGames = new List<Game>
            {
            new Game { Id = 1, CategoryId = 1, Name = "Red Alert 2", Price = 25 },
            new Game { Id = 2,CategoryId = 2,Name = "Mount&Blade Warband",Price = 30},
            new Game { Id = 3,CategoryId = 1,Name = "Age of Empires 2 : HD Edition",Price = 65},
            new Game { Id = 4,CategoryId = 3,Name = "Civilization 6",Price = 140},
            new Game { Id = 5,CategoryId = 3,Name = "Civilization 4",Price = 35}
            };
            List<Campaign> _myCampaigns = new List<Campaign>
            {
            new Campaign { CampaignId = 1, CampaignName = "Bu Fırsat Kaçmaz!" ,  Discount = 15 },
            new Campaign { CampaignId = 2, CampaignName = "5 TL İndirim" ,  Discount = 5 },
            };
            List<Customer> _myCustomers = new List<Customer>();
            Customer customer1 = new Customer();
            customer1.Name = "UMUT";
            customer1.Surname = "MUTLU";
            customer1.DateOfBirth = new DateTime(2155, 05, 05);
            customer1.NationalityId = 11111111111;

            GameManager gm1 = new GameManager(_myGames);
            Game game6 = new Game { Id = 6, CategoryId = 3, Name = "Civilizaion 5", Price = 105 };
            Console.WriteLine(_myGames.Count);
            gm1.Delete(3);
            Console.WriteLine(_myGames.Count);
            gm1.Add(game6);
            Console.WriteLine(_myGames.Count);

            CampaignManager campm1 = new CampaignManager(_myCampaigns);
            campm1.Update(1);

            CustomerManager cm = new CustomerManager(_myCustomers, new MernisServiceAdapter());
            Console.WriteLine(_myCustomers.Count);
            cm.Add(customer1);
            Console.WriteLine(_myCustomers.Count);
        }
    }
}
