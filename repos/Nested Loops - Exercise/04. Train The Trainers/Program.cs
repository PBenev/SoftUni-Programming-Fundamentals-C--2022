using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgeCnt = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double presentationScore;
            double totalScore = 0;
            int cntCourses = 0;

            while (presentationName != "Finish")
            {
                presentationScore = 0;
                cntCourses++;
                for (int i = 0; i < judgeCnt; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    presentationScore += score;
                }
                presentationScore /= judgeCnt;
                Console.WriteLine($"{presentationName} - {presentationScore:F2}.");
                totalScore += presentationScore;
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalScore/cntCourses:F2}.");
        }
    }
}
