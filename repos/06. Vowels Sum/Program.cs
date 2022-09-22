using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            int vollowValue = 0;
            int num = 0;

            for (int i = 0; i < myString.Length; i++)
            {
                char myChar = myString[i];
                switch (myChar)
                {
                    case 'a':
                        vollowValue = 1;
                        break;
                    case 'e':
                        vollowValue = 2;
                        break;
                    case 'i':
                        vollowValue = 3;
                        break;
                    case 'o':
                        vollowValue = 4;
                        break;
                    case 'u':
                        vollowValue = 5;
                        break;
                    default:
                        vollowValue = 0;
                        break;
                }
                num = num + vollowValue;
            }
            Console.WriteLine(num);
        }
    }
}
