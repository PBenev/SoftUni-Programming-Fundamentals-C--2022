using System;

namespace T01.HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneSqMPrice = 7.61;
            double discountP = 18.0;
            double sqMToGreen = double.Parse(Console.ReadLine());
            double totalPrice = sqMToGreen * oneSqMPrice;
            double totalPriceWithDiscount = totalPrice - (discountP / 100) * totalPrice;
            double discountAmount = (discountP / 100) * totalPrice;
            Console.WriteLine($"The final price is: {totalPriceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discountAmount} lv.");
        }
    }
}

