using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cn = 0;
            int nCn = 0;

            for (int i = 0; i < n; i++)
            {
                int myNumber = int.Parse(Console.ReadLine());

                if (i%2 == 0)
                {
                    cn += myNumber;
                }
                else
                {
                    nCn += myNumber;
                }
            }
            if (cn == nCn)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {cn}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(cn-nCn)}");
            }
        }
    }
}
