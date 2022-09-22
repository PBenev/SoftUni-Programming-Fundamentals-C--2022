using System;

namespace ConditionalStatementsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            if (input >= 5.50) 
            { Console.WriteLine("Excellent!");}
        }
    }
}
