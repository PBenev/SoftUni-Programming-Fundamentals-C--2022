using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player = "";
            int goals = 0;
            int maxNum = int.MinValue;
            string bestPlayer = "";
            int bestPlayerGoals = 0;

            while(true)
            {
                player = Console.ReadLine();
                if (player == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
                if (goals > maxNum)
                {
                    maxNum = goals;
                    bestPlayer = player;
                    bestPlayerGoals = goals;
                }
                

                
                if(goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}
