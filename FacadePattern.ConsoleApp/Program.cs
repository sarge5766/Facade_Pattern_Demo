using FacadePattern.Facades;
using System;

namespace FacadePattern.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}
