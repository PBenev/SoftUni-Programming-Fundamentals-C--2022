using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            //calculation
            double boatPrice = 0;

            switch(season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                    boatPrice = 4200;
                    break;
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }

            double discount = 0;
                if (fisherman <= 6)
            {
                discount = 0.1 * boatPrice;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                discount = 0.15 * boatPrice;
            }
            else if (fisherman >= 12)
            {
                discount = 0.25 * boatPrice;
            }

            bool countableFisherman = fisherman % 2 == 0;
            double finalCost = 0;

            if(countableFisherman && season != "Autumn")
            {
                finalCost = boatPrice - discount - (boatPrice - discount) * 0.05;
            }
            else
            {
                finalCost = boatPrice - discount;
            }

            if (groupBudget >= finalCost)
            {
                Console.WriteLine($"Yes! You have {groupBudget - finalCost:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalCost-groupBudget:F2} leva.");
            }
        }
    }
}
