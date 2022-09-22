using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string stringN = n.ToString();
            int cnt = stringN.Length-1;

            int isum = 0;
            int asum = 1;

            for (int i = cnt; i >= 0; i--)
            {
                asum = 1;
                for (int a = stringN[i] - '0'; a > 0; a--)
                {
                    asum *= a;
                }
                isum += asum;
            }
            if (isum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
