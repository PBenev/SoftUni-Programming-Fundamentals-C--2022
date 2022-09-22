using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //calculations
            string destination = "";
            double moneySpend = 0;
            string placeToStay = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneySpend = 0.3 * budget;
                    placeToStay = "Camp";
                }
                else
                {
                    moneySpend = 0.7 * budget;
                    placeToStay = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneySpend = 0.4 * budget;
                    placeToStay = "Camp";
                }
                else
                {
                    moneySpend = 0.8 * budget;
                    placeToStay = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                moneySpend = 0.9 * budget;
                placeToStay = "Hotel";
            }

            //print
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {moneySpend:F2}");
        }
    }
}
