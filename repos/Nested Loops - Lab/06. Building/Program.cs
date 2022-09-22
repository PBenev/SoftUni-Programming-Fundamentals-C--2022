using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cntFloors = int.Parse(Console.ReadLine());
            int cntRooms = int.Parse(Console.ReadLine());

            for (int i = cntFloors; i > 0; i--)
            {
                for (int j = 0; j < cntRooms; j++)
                {
                    if (i == cntFloors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i%2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
