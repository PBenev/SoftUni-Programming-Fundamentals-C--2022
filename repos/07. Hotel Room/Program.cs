using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string month = Console.ReadLine();
            int daysDuration = int.Parse(Console.ReadLine());

            //prices
            double studioCost = 0;
            double appartmantCost = 0;

            if (month == "May" || month == "October")
            {
                studioCost = 50*daysDuration;
                appartmantCost = 65 * daysDuration;
            }
            else if (month == "June" || month == "September")
            {
                studioCost = 75.2 * daysDuration;
                appartmantCost = 68.7 * daysDuration;
            }
            else
            {
                studioCost = 76 * daysDuration;
                appartmantCost = 77 * daysDuration;
            }

            //calculate discounts
            if (daysDuration > 14)
            {
                appartmantCost = appartmantCost - (appartmantCost * 0.1);
            }
            if ((month == "May" || month == "October") && (daysDuration > 7 && daysDuration <= 14))
            {
                studioCost = studioCost - (studioCost * 0.05);
            }
            else if ((month == "May" || month == "October") && daysDuration > 14)
            {
                studioCost = studioCost - (studioCost * 0.3);
            }
            else if ((month == "June" || month == "September") && daysDuration > 14)
            {
                studioCost = studioCost - (studioCost * 0.2);
            }

            //print
            Console.WriteLine($"Apartment: {appartmantCost:F2} lv.");
            Console.WriteLine($"Studio: {studioCost:F2} lv.");
        }
    }
}
