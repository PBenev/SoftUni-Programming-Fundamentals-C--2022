using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntTournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());

            double totalPoints = 0;
            double cntWins = 0;

            for (int i = 0; i < cntTournaments; i++)
            {
                string tournamentPlace = Console.ReadLine();
                switch (tournamentPlace)
                {
                    case "W":
                        totalPoints += 2000;
                        cntWins++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {totalPoints+initialPoints}");
            Console.WriteLine($"Average points: {Math.Floor(totalPoints/cntTournaments)}");
            Console.WriteLine($"{cntWins/cntTournaments*100:F2}%");

        }
    }
}
