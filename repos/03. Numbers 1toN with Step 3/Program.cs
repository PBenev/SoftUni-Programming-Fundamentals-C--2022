using System;

namespace _03._Numbers_1toN_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int myN = 1;myN <= n; myN += 3)
            {
                Console.WriteLine(myN);
            }
        }
    }
}
