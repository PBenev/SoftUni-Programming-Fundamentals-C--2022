using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int myN = 0; myN <= n; myN+=2)
            {
                    Console.WriteLine(num);
                    num = num * 2 * 2;
            }
        }
    }
}
