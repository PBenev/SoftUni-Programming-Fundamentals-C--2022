using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            

            //calculations
            int calculatedHours = 0;
            int calculatedMinutes = 0;
            if (minutes >= 45)
            {
                if (hours == 23)
                {
                    calculatedHours = 0;
                }
                else
                {
                    calculatedHours = hours + 1;
                }
            }
            else
            {
                calculatedHours = hours;
            }
            calculatedMinutes = (minutes + 15) % 60;
            if (calculatedMinutes <10 )
            {
                Console.WriteLine($"{calculatedHours}:0{calculatedMinutes}");
            }
            else
            {
                Console.WriteLine($"{calculatedHours}:{calculatedMinutes}");
            }
        }
    }
}
