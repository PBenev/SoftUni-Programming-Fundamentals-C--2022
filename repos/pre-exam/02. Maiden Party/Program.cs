using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int cntLoveMessages = int.Parse(Console.ReadLine());
            int cntLaxRoses = int.Parse(Console.ReadLine());
            int cntKliuchodyrjateli = int.Parse(Console.ReadLine());
            int cntKarikaturi = int.Parse(Console.ReadLine());
            int cntSurprises = int.Parse(Console.ReadLine());

            //static variables
            double priceLoveMessages = 0.6;
            double priceLaxRoses = 7.2;
            double priceKliuchodyrjatel = 3.6;
            double priceKarikaturi = 18.2;
            double priceSurprises = 22;

            double totalPriceLoveMessages = cntLoveMessages * priceLoveMessages;
            double totalPriceLaxRoses = cntLaxRoses * priceLaxRoses;
            double totalPriceKliuchodyrjateli = cntKliuchodyrjateli * priceKliuchodyrjatel;
            double totalPriceKarikaturi = cntKarikaturi * priceKarikaturi;
            double totalPriceSurprises = cntSurprises * priceSurprises;

            double totalPrice = totalPriceLoveMessages + totalPriceLaxRoses + totalPriceKliuchodyrjateli + totalPriceKarikaturi + totalPriceSurprises;
            if (cntLoveMessages+ cntLaxRoses+ cntKliuchodyrjateli+ cntKarikaturi+ cntSurprises >= 25)
            {
                totalPrice = totalPrice - 0.35 * totalPrice;
            }
            totalPrice = totalPrice - totalPrice * 0.1;

            if (totalPrice >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {totalPrice-maidenPartyPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {maidenPartyPrice-totalPrice:F2} lv needed.");
            }
        }
    }
}
