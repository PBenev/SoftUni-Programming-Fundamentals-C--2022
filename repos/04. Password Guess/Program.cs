﻿using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string password = Console.ReadLine();

            // Static variable
            string correctPassword = "s3cr3t!P@ssw0rd";

            // Print
            if (password == correctPassword)
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
