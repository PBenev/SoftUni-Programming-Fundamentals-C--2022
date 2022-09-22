using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int countPencilPackages = int.Parse(Console.ReadLine());
            int countMarketPackages = int.Parse(Console.ReadLine());
            int cleaningLiquidAmount = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //Static variables (Prices)
            double pencilPackagePrice = 5.80;
            double markersPackagePrice = 7.20;
            double cleaningLiquidPrice = 1.2;

            //Discount %
            double discountPercent = discount / 100.00;

            //Total cost without discount
            double totalPrice = countPencilPackages * pencilPackagePrice + countMarketPackages * markersPackagePrice + cleaningLiquidAmount * cleaningLiquidPrice;

            //Discount amount
            double discountAmount = totalPrice * discountPercent;

            //print
            Console.WriteLine(totalPrice-discountAmount);
        }
    }
}
