﻿using System;

namespace _05._Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            int myNumber = int.Parse(Console.ReadLine());

            // Print
            if (myNumber < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (myNumber >= 100 && myNumber <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            } else if (myNumber > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
