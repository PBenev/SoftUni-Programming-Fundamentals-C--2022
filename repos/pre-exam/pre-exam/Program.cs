using System;

namespace pre_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int cntPeople = int.Parse(Console.ReadLine());
            int cntNights = int.Parse(Console.ReadLine());
            int cntCards = int.Parse(Console.ReadLine());
            int cntTickets = int.Parse(Console.ReadLine());

            //static variables
            double nightPrice = 20;
            double cardPrice = 1.6;
            double ticketPrice = 6;

            double totalNightPrice = cntNights * nightPrice;
            double totalCardPrice = cntCards * cardPrice;
            double totalTicketsPrice = cntTickets * ticketPrice;

            double totalCost = (totalNightPrice + totalCardPrice + totalTicketsPrice)*cntPeople;
            totalCost = totalCost + 0.25 * totalCost;

            Console.WriteLine("{0:F2}",totalCost);
        }
    }
}
