using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i > 1)
                {
                    Console.WriteLine();
                }
                for (int a = 1; a <= i; a++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
