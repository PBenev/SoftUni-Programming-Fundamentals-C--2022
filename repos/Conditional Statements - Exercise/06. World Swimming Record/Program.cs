using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            //calculations
            double timeWithoutPressure = distanceInMeters * timePerMeterInSeconds;
            int pressureSeconds = (int)Math.Floor(distanceInMeters)/15;
            double pressureSecondsFinal = pressureSeconds * 12.5;
            double timeWithPressure = timeWithoutPressure + pressureSecondsFinal;

            //print
            bool success = timeWithPressure < recordInSeconds;

            if (success)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {timeWithPressure:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeWithPressure-recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
