using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int duration = int.Parse(Console.ReadLine());
            string accomodation = Console.ReadLine();
            string feedback = Console.ReadLine();

            //calculations
            double accomodationPrice = 0;
            if (accomodation == "room for one person")
            {
                accomodationPrice = (duration - 1) * 18.00;
            }
            else if (accomodation == "apartment")
            {
                if (duration < 10)
                {
                    accomodationPrice = (duration-1)*25.00 - ((duration - 1) * 25.00)*0.3;
                }
                else if (duration >= 10 && duration < 15)
                {
                    accomodationPrice = (duration - 1) * 25.00 - ((duration - 1) * 25.00) * 0.35;
                }
                else
                {
                    accomodationPrice = (duration - 1) * 25.00 - ((duration - 1) * 25.00) * 0.5;
                }
            }
            else
            {
                if (duration < 10)
                {
                    accomodationPrice = (duration - 1) * 35.00 - ((duration - 1) * 35.00) * 0.1;
                }
                else if (duration >= 10 && duration < 15)
                {
                    accomodationPrice = (duration - 1) * 35.00 - ((duration - 1) * 35.00) * 0.15;
                }
                else
                {
                    accomodationPrice = (duration - 1) * 35.00 - ((duration - 1) * 35.00) * 0.2;
                }
            }

            //feedback
            if (feedback == "positive")
            {
                accomodationPrice = accomodationPrice + 0.25 * accomodationPrice;
            }
            else
            {
                accomodationPrice = accomodationPrice - accomodationPrice * 0.1;
            }

            //print
            Console.WriteLine("{0:F2}",accomodationPrice);
        }
    }
}
