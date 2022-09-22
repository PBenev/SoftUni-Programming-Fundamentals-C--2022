using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double amount = double.Parse(Console.ReadLine());
            double cntStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLightSaberPrice = (Math.Ceiling(cntStudents * 0.1) + cntStudents) * lightsaberPrice;
            double totalBeltsPrice = (cntStudents - (Math.Floor(cntStudents / 6)))*beltsPrice;

            double totalPrice = totalLightSaberPrice + totalBeltsPrice + robesPrice * cntStudents;

            if (totalPrice <= amount)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - amount:F2}lv more.");
            }
        }
    }
}
