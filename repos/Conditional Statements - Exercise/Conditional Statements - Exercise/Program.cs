using System;

namespace Conditional_Statements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int result1 = int.Parse(Console.ReadLine());
            int result2 = int.Parse(Console.ReadLine());
            int result3 = int.Parse(Console.ReadLine());

            //calculation
            int totalTime = result1 + result2 + result3;
            int minutes = totalTime/60;
            int seconds = totalTime % 60;

            //print
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
