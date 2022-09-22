using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 1;
            int sum = 0;

            while (n > 0)
            {
                Console.WriteLine(cnt);
                sum += cnt;
                cnt += 2;
                n--;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
