using System;

namespace _04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cntDays = int.Parse(Console.ReadLine());
            double liters = 0;
            double degree = 0;
            double totalLiters = 0;
            double totalDegrees = 0;

            for (int i = 0; i < cntDays; i++)
            {
                liters = double.Parse(Console.ReadLine());
                degree = double.Parse(Console.ReadLine());

                totalLiters += liters;
                double degreeToLiters = liters * degree;
                totalDegrees += degreeToLiters;
            }
            totalDegrees = totalDegrees / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:F2}");
            Console.WriteLine($"Degrees: {totalDegrees:F2}");
            if (totalDegrees < 38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            else if (totalDegrees >= 38 && totalDegrees < 42)
            {
                Console.WriteLine($"Super!");
            }
            else
            {
                Console.WriteLine($"Dilution with distilled water!");
            }
        }
    }
}
