using System;

namespace _06._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int number = int.Parse(Console.ReadLine());

            //print
            if (number >= -100 && number <=100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
