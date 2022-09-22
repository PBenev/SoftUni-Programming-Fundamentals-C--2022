using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int counterIfFound = 0;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {
                    counter++;
                    if (i+j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        counterIfFound++;
                        break;
                    }
                }
                if (counterIfFound > 0)
                {
                    break;
                }
            }
            if (counterIfFound == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
