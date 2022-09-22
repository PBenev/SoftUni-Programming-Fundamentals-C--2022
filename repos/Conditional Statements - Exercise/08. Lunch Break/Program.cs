using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string movieName = Console.ReadLine();
            int movieLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            //calculations
            double lunchBreak = (1.0 / 8.0) * breakLength;
            double restBreak = breakLength * 0.25;

            //print
            double totalTime = lunchBreak + restBreak + movieLength;
            bool enoughTime = breakLength >= totalTime;

            if (enoughTime)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(breakLength-totalTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(totalTime-breakLength)} more minutes.");
            }
        }
    }
}
