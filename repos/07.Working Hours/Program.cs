using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            //print
            if (hour >= 10 && hour <= 18 && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            } else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
