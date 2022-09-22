using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double movieBudget = double.Parse(Console.ReadLine());
            int pplNeeded = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            //static variables
            double decor = movieBudget * 0.1;

            //calculations
            double totalDressPrice = pplNeeded * dressPrice;
            if (pplNeeded > 150)
            {
                totalDressPrice = totalDressPrice - totalDressPrice * 0.1;
            }
            double totalPrice = totalDressPrice + decor;
            bool isMoneyEnough = totalPrice > movieBudget;

            if (isMoneyEnough)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice-movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget-totalPrice:F2} leva left.");
            }
        }
    }
}
