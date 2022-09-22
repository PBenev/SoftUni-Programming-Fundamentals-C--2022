using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int annualPrice = int.Parse(Console.ReadLine());

            //Statis variable
            int shoesPercent = 40;
            int suitePercent = 20;
            double ballPercent = (1.0 / 4.0) * 100.0;
            double accessoriesPercent = (1.0 / 5.0) * 100.0;

            //Prices
            double shoesPrice = annualPrice - (shoesPercent / 100.00) * annualPrice;
            double suitePrice = shoesPrice - (suitePercent / 100.00) * shoesPrice;
            double ballPrice = (ballPercent / 100.00) * suitePrice;
            double accessoriesPrice = (accessoriesPercent / 100.00) * ballPrice;

            //Print
            Console.WriteLine(shoesPrice+ suitePrice+ ballPrice+ accessoriesPrice+ annualPrice);
        }
    }
}
