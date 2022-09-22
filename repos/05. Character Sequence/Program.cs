using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }
        }
    }
}
