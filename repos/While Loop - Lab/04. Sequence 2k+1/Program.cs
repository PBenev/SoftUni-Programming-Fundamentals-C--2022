using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = int.Parse(Console.ReadLine());
            int myNum2 = 0;
            while (true)
            {
                myNum2 = myNum2 * 2 + 1;
                if (myNum2 <= myNum)
                {
                    Console.WriteLine(myNum2);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
