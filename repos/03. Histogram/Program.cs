using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;

            for (int i = 0; i < n; i++)
            {
                int myNum = int.Parse(Console.ReadLine());

                if (myNum < 200)
                {
                    p1Count++;
                }
                else if (myNum >= 200 && myNum <= 399)
                {
                    p2Count++;
                }
                else if (myNum > 399 && myNum <= 599)
                {
                    p3Count++;
                }
                else if (myNum > 599 && myNum <= 799)
                {
                    p4Count++;
                }
                else
                {
                    p5Count++;
                }
            }
            Console.WriteLine($"{Convert.ToDouble(p1Count)/ Convert.ToDouble(n)*100:F2}%");
            Console.WriteLine($"{Convert.ToDouble(p2Count) / Convert.ToDouble(n) * 100:F2}%");
            Console.WriteLine($"{Convert.ToDouble(p3Count) / Convert.ToDouble(n) * 100:F2}%");
            Console.WriteLine($"{Convert.ToDouble(p4Count) / Convert.ToDouble(n) * 100:F2}%");
            Console.WriteLine($"{Convert.ToDouble(p5Count) / Convert.ToDouble(n) * 100:F2}%");
        }
    }
}
