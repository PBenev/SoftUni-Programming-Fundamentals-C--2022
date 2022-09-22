using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string flowerType = Console.ReadLine();
            int flowerQty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // static variables
            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;

            //print
            double amountNeeded = 0;
            switch (flowerType)
            {
                case "Roses":
                    amountNeeded = flowerQty * rosePrice;
                    break;
                case "Dahlias":
                    amountNeeded = flowerQty * dahliaPrice;
                    break;
                case "Tulips":
                    amountNeeded = flowerQty * tulipPrice;
                    break;
                case "Narcissus":
                    amountNeeded = flowerQty * narcissusPrice;
                    break;
                case "Gladiolus":
                    amountNeeded = flowerQty * gladiolusPrice;
                    break;
            }

            if (flowerType == "Roses" && flowerQty > 80)
            {
                amountNeeded = amountNeeded - (0.1 * amountNeeded);
            }
            else if (flowerType == "Dahlias" && flowerQty > 90)
            {
                amountNeeded = amountNeeded - (0.15 * amountNeeded);
            }
            else if (flowerType == "Tulips" && flowerQty > 80)
            {
                amountNeeded = amountNeeded - (0.15 * amountNeeded);
            }
            else if (flowerType == "Narcissus" && flowerQty < 120)
            {
                amountNeeded = amountNeeded + (0.15 * amountNeeded);
            }
            else if (flowerType == "Gladiolus" && flowerQty < 80)
            {
                amountNeeded = amountNeeded + (0.2 * amountNeeded);
            }

            if (budget >= amountNeeded)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQty} {flowerType} and {budget-amountNeeded:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {amountNeeded - budget:F2} leva more.");
            }
            
        }
    }
}
