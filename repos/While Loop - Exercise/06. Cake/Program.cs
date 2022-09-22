using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cntCakePieces = 0;
            int cakeSize = width * length;

            while(cakeSize > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cntCakePieces++;
                cakeSize -= int.Parse(input);
            }
            if (cakeSize >= 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}
