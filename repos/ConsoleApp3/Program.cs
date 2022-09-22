using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int owningBitcoins = int.Parse(Console.ReadLine());
            double owningChineseJoans = double.Parse(Console.ReadLine());
            double commicion = double.Parse(Console.ReadLine());

            //static variable
            int bitcoin = 1168;
            double dollar = 1.76;
            double chineseJoan = 0.15 * dollar;
            double euro = 1.95;
            double euroToBGN = 1.0 / euro;

            //calculation
            double totalPriceNoCommicion = (owningBitcoins * bitcoin + owningChineseJoans * chineseJoan)*euroToBGN;
            double totalComiccion = totalPriceNoCommicion * (commicion / 100.0);

            //print
            Console.WriteLine(owningBitcoins*bitcoin);
            Console.WriteLine(owningChineseJoans*chineseJoan);
            Console.WriteLine("{0:F2}",totalPriceNoCommicion-totalComiccion);
        }
    }
}
