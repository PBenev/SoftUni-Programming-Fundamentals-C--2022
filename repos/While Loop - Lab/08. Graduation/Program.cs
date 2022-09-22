using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentGrade = 1;
            double sumGrades = 0;
            int cntFails = 0;

            while (currentGrade <= 12)
            {
                double grade = double.Parse(Console.ReadLine());    

                if (grade < 4)
                {
                    cntFails++;
                    if(cntFails > 1)
                    {
                        break;
                    }
                    continue;
                }
                currentGrade++;
                sumGrades += grade;
            }
            if (currentGrade < 12)
            {
                Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrades/12:F2}");
            }
        }
    }
}
