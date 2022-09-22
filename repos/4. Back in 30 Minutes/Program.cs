using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int waitingtime = 30;

            if (minutes>29)
            {
                if (hours == 23)
                {
                    hours = 0;
                }
                else
                {
                    hours = hours + 1;
                }
                minutes = minutes + waitingtime - 60;
            }
            else
            {
                minutes = minutes + waitingtime;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
