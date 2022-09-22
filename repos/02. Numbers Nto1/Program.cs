using System;

namespace _02._Numbers_Nto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int myN = n; myN >= 1; myN--)
            {
                Console.WriteLine(myN);
            }
        }
    }
}
