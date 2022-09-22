using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string actorName = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());
            int countOfJudges = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            for (int i = 0; i < countOfJudges; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                totalPoints = totalPoints + (judgeName.Length * judgePoints) / 2;
                if (totalPoints+initialPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints+initialPoints:F1}!");
                    break;
                }
            }
            if (totalPoints+initialPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5-(totalPoints+initialPoints):F1} more!");
            }
        }
    }
}
