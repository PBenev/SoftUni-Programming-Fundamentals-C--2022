using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int leftPart = int.Parse(Console.ReadLine());
                sum1 += leftPart;
            }
            for (int i = 0; i < n; i++)
            {
                int rightPart = int.Parse(Console.ReadLine());
                sum2 += rightPart;
            }

            if (sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
