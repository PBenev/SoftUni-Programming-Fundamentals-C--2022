using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeNeeded = double.Parse(Console.ReadLine());
            changeNeeded *= 100.0;
            changeNeeded = Math.Round(changeNeeded, 2);

            int counter = 0;

            while(changeNeeded>0)
             {
                if (changeNeeded >= 200)
                {
                    changeNeeded -= 200;
                    counter++;
                }
                else if (changeNeeded >= 100)
                {
                    changeNeeded -= 100;
                    counter++;
                }
                else if (changeNeeded >= 50)
                {
                    changeNeeded -= 50;
                    counter++;
                } else if (changeNeeded >= 20)
                {
                    changeNeeded -=20;
                    counter++;
                } else if (changeNeeded >= 10)
                {
                    changeNeeded -=10;
                    counter++;
                }
                else if (changeNeeded >= 5)
                {
                    changeNeeded -= 5;
                    counter++;
                }
                else if (changeNeeded >= 2)
                {
                    changeNeeded -= 2;
                    counter++;
                }
                else
                {
                    changeNeeded -= 1;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
