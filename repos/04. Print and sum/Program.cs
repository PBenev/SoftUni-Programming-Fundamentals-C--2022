﻿using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = n1; i <= n2; i++)
            {
                if (i == n2)
                {
                    Console.WriteLine($"{i} ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}