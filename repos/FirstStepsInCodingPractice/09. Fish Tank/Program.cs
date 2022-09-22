using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int lengthCM = int.Parse(Console.ReadLine());
            int widthCM = int.Parse(Console.ReadLine());
            int heightCM = int.Parse(Console.ReadLine());
            double percentOccupied = double.Parse(Console.ReadLine());

            //calculation
            double lengthDM = lengthCM / 10.00;
            double widthDM = widthCM / 10.00;
            double heightDM = heightCM / 10.00;
            double totalCapacity = lengthDM * widthDM * heightDM;
            double occupiedCapacity = (percentOccupied / 100.00) * totalCapacity;

            //print
            Console.WriteLine(totalCapacity- occupiedCapacity);
        }
    }
}
