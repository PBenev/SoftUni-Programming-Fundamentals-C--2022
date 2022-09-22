using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaceWidth = int.Parse(Console.ReadLine());
            int spaceLength = int.Parse(Console.ReadLine());
            int spaceHeight = int.Parse(Console.ReadLine());

            int cntBoxes = 0;
            int space = spaceWidth * spaceLength * spaceHeight;

            while(space > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                cntBoxes++;
                space -= int.Parse(input);
            }
            if (space >= 0)
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
            }
        }
    }
}
