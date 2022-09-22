using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sumCountables = 0;
            int sumUnCountables = 0;

            for (int i = num1; i <= num2; i++)
            {
                sumCountables = ((int)(i.ToString()[0]) - 48) + ((int)(i.ToString()[2]) - 48) + ((int)(i.ToString()[4]) - 48);
            sumUnCountables = ((int)(i.ToString()[1]) - 48) + ((int)(i.ToString()[3]) - 48) + ((int)(i.ToString()[5]) - 48);

                if (sumUnCountables == sumCountables)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
