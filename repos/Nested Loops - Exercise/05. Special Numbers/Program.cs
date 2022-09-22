using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numAsString = "";
            bool toPass = true;

            for (int i = 1111; i <= 9999; i++)
            {
                numAsString = i.ToString();
                toPass = true;
                for (int j = 0; j < numAsString.Length; j++)
                {
                    int myInt = numAsString[j]-48;
                    if (myInt == 0 || num % myInt > 0)
                    {
                        toPass = false;
                        break;
                    }
                }
                if (toPass)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
