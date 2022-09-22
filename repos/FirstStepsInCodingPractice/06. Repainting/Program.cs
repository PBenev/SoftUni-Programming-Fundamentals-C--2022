using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int neededNylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededThinner = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());

            //Static variables (Prices)
            double nylonPrice = 1.50;
            double paintPrice = 14.50;
            double thinnerPrice = 5.00;
            double plasticBags = 0.40;

            //Additional costs
            int percentAdditionalPaint = 10;
            int additionalNylon = 2;
            double additionalPaintPrice = (percentAdditionalPaint / 100.00) * (neededPaint * paintPrice);
            double additionalNylonPrice = additionalNylon * nylonPrice;

            //Material's cost
            double totalNylonPrice = neededNylon * nylonPrice + additionalNylonPrice;
            double totalPaintPrice = neededPaint * paintPrice + additionalPaintPrice;
            double totalThinnerPrice = neededThinner * thinnerPrice;
            double totalMaterialPrice = totalNylonPrice + totalPaintPrice + plasticBags + totalThinnerPrice;

            //Repairmen's cost
            int percentOfMaterial = 30;
            double percentToAmoutOfMaterial = (percentOfMaterial / 100.00) * totalMaterialPrice;

            //print
            Console.WriteLine(totalMaterialPrice+ percentToAmoutOfMaterial* neededHours);
        }
    }
}
