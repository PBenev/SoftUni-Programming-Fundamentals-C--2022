using System;

namespace C_sharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avgGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}",studentName, age, avgGrade);
        }
    }
}
