using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            // global input
            string figureType = Console.ReadLine();

            // local input
            if (figureType == "square")
            {
                // local variable
                double sqArea = double.Parse(Console.ReadLine());

                //result
                Console.WriteLine("{0:F3}", sqArea * sqArea);
            }
            else if (figureType == "rectangle")
            {
                // local variable
                double recArea1 = double.Parse(Console.ReadLine());
                double recArea2 = double.Parse(Console.ReadLine());

                //result
                Console.WriteLine("{0:F3}", recArea1 * recArea2);
            }
            else if (figureType == "circle")
            {
                // local variable
                double circArea = double.Parse(Console.ReadLine());

                //result
                Console.WriteLine("{0:F3}", (circArea * circArea) * Math.PI);
            }
            else if (figureType == "triangle")
            {
                // local variable
                double triaArea1 = double.Parse(Console.ReadLine());
                double triaArea2 = double.Parse(Console.ReadLine());

                //result
                Console.WriteLine("{0:F3}", (triaArea1 * triaArea2) / 2);
            }
        }
    }
}