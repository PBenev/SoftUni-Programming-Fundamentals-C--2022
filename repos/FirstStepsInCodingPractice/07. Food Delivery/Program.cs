using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int countChickenMenus = int.Parse(Console.ReadLine());
            int countFishMenus = int.Parse(Console.ReadLine());
            int countVegiMenus = int.Parse(Console.ReadLine());

            //Statis variables
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegiMenuPrice = 8.15;
            double deliveryPrice = 2.50;
            int dessertPercent = 20;

            //Prices
            double totalChickenMenuPrice = countChickenMenus * chickenMenuPrice;
            double totalFishMenuPrice = countFishMenus * fishMenuPrice;
            double totalVegiMenuPrice = countVegiMenus * vegiMenuPrice;
            double totalMenuPriceNoDessert = totalChickenMenuPrice + totalFishMenuPrice + totalVegiMenuPrice;
            double totalDessertPrice = (dessertPercent / 100.00) * totalMenuPriceNoDessert;

            //Print
            Console.WriteLine(totalMenuPriceNoDessert + totalDessertPrice + deliveryPrice);
        }
    }
}
