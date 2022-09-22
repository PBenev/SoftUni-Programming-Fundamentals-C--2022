using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int proccessorsCount = int.Parse(Console.ReadLine());
            int RAMCount = int.Parse(Console.ReadLine());

            //static variables
            double videoCardsPrice = 250;
            double proccessorsPrice = (videoCardsPrice * videoCardsCount) * 0.35;
            double RAMPrice = (videoCardsPrice * videoCardsCount) * 0.1;

            //calculations
            double totalCost = videoCardsCount * videoCardsPrice + proccessorsPrice * proccessorsCount + RAMPrice * RAMCount;
            if (videoCardsCount>proccessorsCount)
            {
                totalCost = totalCost - (totalCost * 0.15);
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"You have {budget - totalCost:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost-budget:F2} leva more!");
            }
        }
    }
}
