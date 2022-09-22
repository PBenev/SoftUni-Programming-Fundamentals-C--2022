using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = 0;

            while(true){
                int secondaryNumber = int.Parse(Console.ReadLine());
                N2 += secondaryNumber;
                if(N2 >= N1)
                {
                    Console.WriteLine(N2);
                    break;
                }
            }
        }
    }
}
