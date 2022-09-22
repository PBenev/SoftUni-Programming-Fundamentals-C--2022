using System;

namespace Nested_Loops___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            int revCounter = number;
            int myNum = 0;

            for (int i = 1; i <= revCounter; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i} ");
                    myNum = 1;
                }
                else
                {
                    counter++;
                    revCounter--;
                    for (int j = 1; j <= counter; j++)
                    {
                        myNum++;
                        if (myNum <= number)
                        {
                            Console.Write($"{myNum} ");
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (myNum <= number) { 
                    Console.WriteLine();
                }else
                {
                    break;
                }
                }
            }
        }
    }
}
