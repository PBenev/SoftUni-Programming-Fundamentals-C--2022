using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string city = Console.ReadLine();
            double salesAmount = double.Parse(Console.ReadLine());

            //Print
            if (city == "Sofia")
            {
                if (salesAmount >= 0 && salesAmount <= 500)
                {
                    Console.WriteLine("{0:F2}", 0.05 * salesAmount);
                }
                else if (salesAmount > 500 && salesAmount <= 1000)
                {
                    Console.WriteLine("{0:F2}", 0.07 * salesAmount);
                }
                else if (salesAmount > 1000 && salesAmount <= 10000)
                {
                    Console.WriteLine("{0:F2}", 0.08 * salesAmount);
                }
                else if (salesAmount > 10000)
                {
                    Console.WriteLine("{0:F2}", 0.12 * salesAmount);
                }
                else
                {
                    Console.WriteLine("error");                
                }
            }
            else if (city == "Varna")
            {
                if (salesAmount >= 0 && salesAmount <= 500)
                {
                    Console.WriteLine("{0:F2}", 0.045 * salesAmount);
                }
                else if (salesAmount > 500 && salesAmount <= 1000)
                {
                    Console.WriteLine("{0:F2}", 0.075 * salesAmount);
                }
                else if (salesAmount > 1000 && salesAmount <= 10000)
                {
                    Console.WriteLine("{0:F2}", 0.1 * salesAmount);
                }
                else if (salesAmount > 10000)
                {
                    Console.WriteLine("{0:F2}", 0.13 * salesAmount);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (salesAmount >= 0 && salesAmount <= 500)
                {
                    Console.WriteLine("{0:F2}", 0.055 * salesAmount);
                }
                else if (salesAmount > 500 && salesAmount <= 1000)
                {
                    Console.WriteLine("{0:F2}", 0.08 * salesAmount);
                }
                else if (salesAmount > 1000 && salesAmount <= 10000)
                {
                    Console.WriteLine("{0:F2}", 0.12 * salesAmount);
                }
                else if (salesAmount > 10000)
                {
                    Console.WriteLine("{0:F2}", 0.145 * salesAmount);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
