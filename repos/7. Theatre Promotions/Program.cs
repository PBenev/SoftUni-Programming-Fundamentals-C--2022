using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int cost = 0;

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    cost = 12;
                }
                else if (age> 18 && age <= 64)
                {
                    cost = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    cost = 12;
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    cost = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    cost = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    cost = 15;
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    cost = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    cost = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    cost = 10;
                }
            }
            if (cost == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{cost}$");
            }
        }
    }
}
