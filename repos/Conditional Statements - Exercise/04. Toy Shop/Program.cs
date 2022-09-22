using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollsCount = int.Parse(Console.ReadLine());
            int fluffyBearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            //static variable
            double puzzlePrice = 2.60;
            double talkingDollsPrice = 3.0;
            double fluffyBearsPrice = 4.10;
            double minionsPrice = 8.20;
            double trucksPrice = 2.0;

            //calculations
            double totalPuzzlePrice = Math.Round(puzzlePrice * puzzleCount,2);
            double totalTalkingDollsPrice = Math.Round(talkingDollsPrice * talkingDollsCount,2);
            double totalFluffyBearsPrice = Math.Round(fluffyBearsPrice * fluffyBearsCount,2);
            double totalMinionsPrice = Math.Round(minionsPrice * minionsCount,2);
            double totalTrucksPrice = Math.Round(trucksPrice * trucksCount,2);

            double totalPrice = totalPuzzlePrice+totalTalkingDollsPrice+totalFluffyBearsPrice+totalMinionsPrice+totalTrucksPrice;
            int totalQty = puzzleCount + talkingDollsCount + fluffyBearsCount + minionsCount + trucksCount;
            bool QtyGt50 = totalQty >= 50;

            if (QtyGt50)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            double rent = 0.1 * totalPrice;
            double profit = totalPrice - rent;

            //print
            
            if (profit > tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:F2} lv needed.");
            };
            /*Console.WriteLine(profit);
            Console.WriteLine(rent);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalPuzzlePrice);
            Console.WriteLine(totalTalkingDollsPrice);
            Console.WriteLine(totalFluffyBearsPrice);
            Console.WriteLine(totalMinionsPrice);
            Console.WriteLine(totalTrucksPrice);*/
        }
    }
}
