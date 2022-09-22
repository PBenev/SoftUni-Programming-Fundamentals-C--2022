using System;

namespace _06._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1Border = int.Parse(Console.ReadLine());
            int n2Border = int.Parse(Console.ReadLine());
            int n3Border = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i <= n1Border; i++)
            {
                if (i%2 > 0)
                {
                    continue;
                }
                for (int j = 2; j <= n2Border; j++)
                {
                    for (int x = 2; x <= j; x++)
                    {
                        isPrime = true;
                        if (j % x == 0 && j != x)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (!isPrime) { continue; }
                    for (int g = 2; g <= n3Border; g++)
                    {
                        
                        if (g%2 > 0)
                        {
                            continue;
                        }
                        Console.Write($"{i} {j} {g}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
