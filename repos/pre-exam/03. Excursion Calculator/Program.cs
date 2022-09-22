using System;

namespace _03._Excursion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int cntPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if (season == "spring")
            {
                if (cntPeople <= 5)
                {
                    price = cntPeople * 50.00;
                }
                else
                {
                    price = cntPeople * 48.00;
                }
            }
            else if (season == "summer")
            {
                if (cntPeople <= 5)
                {
                    price = cntPeople * 48.5;
                }
                else
                {
                    price = cntPeople * 45.00;
                }
            }
            else if (season == "autumn")
            {
                if (cntPeople <= 5)
                {
                    price = cntPeople * 60.0;
                }
                else
                {
                    price = cntPeople * 49.50;
                }
            } else
            {
                if (cntPeople <= 5)
                {
                    price = cntPeople * 86.0;
                }
                else
                {
                    price = cntPeople * 85.00;
                }
            }
            if (season == "summer")
            {
                price = price - 0.15 * price;
            } else if(season == "winter")
            {
                price = price + 0.08 * price;
            }

            Console.WriteLine($"{price:F2} leva.");
        }
    }
}
