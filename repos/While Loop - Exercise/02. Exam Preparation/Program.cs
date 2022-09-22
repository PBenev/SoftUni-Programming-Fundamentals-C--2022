using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cntAllowedUnsufficientGrades = int.Parse(Console.ReadLine());
            int sumGrades = 0;
            int cntUnsufficientGrades = 0;
            double cntTaks = 0;
            string lastAssignmentName = "";

            while (true)
            {
                string assignmentName = Console.ReadLine();
                if (assignmentName == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades / cntTaks:F2}");
                    Console.WriteLine($"Number of problems: {cntTaks}");
                    Console.WriteLine($"Last problem: {lastAssignmentName}");
                    break;
                }
                else
                {
                    lastAssignmentName = assignmentName;
                }
                int grade = int.Parse(Console.ReadLine());
                cntTaks++;



                if(grade <= 4)
                {
                    cntUnsufficientGrades++;
                    if (cntUnsufficientGrades == cntAllowedUnsufficientGrades)
                    {
                        Console.WriteLine($"You need a break, {cntUnsufficientGrades} poor grades.");
                        break;
                    } else
                    {
                        sumGrades += grade;
                    }
                }
                else
                {
                    sumGrades += grade;
                }
            }
        }
    }
}
