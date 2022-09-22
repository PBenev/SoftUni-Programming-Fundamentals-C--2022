using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxN = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int myNum = int.Parse(Console.ReadLine());
                if (myNum > maxN)
                {
                    maxN = myNum;
                }

                sum = sum += myNum;
            }

            if (sum == maxN*2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxN}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxN - (sum-maxN))}");
            }
        }
    }
}
