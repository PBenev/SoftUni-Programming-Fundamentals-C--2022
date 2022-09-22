using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mySum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {mySum:F2}");
                    break;
                }
                else if (Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {mySum:F2}");
                    break;
                }
                else
                {
                    mySum += Convert.ToDouble(input);
                    Console.WriteLine($"Increase: {Convert.ToDouble(input):F2}");
                }
            }
        }
    }
}
