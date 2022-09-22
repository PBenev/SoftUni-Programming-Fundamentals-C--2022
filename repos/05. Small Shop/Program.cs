using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            //calculations
            double price = 0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.50 * qty);
                        break;
                    case "water":
                        Console.WriteLine(0.80 * qty);
                        break;
                    case "beer":
                        Console.WriteLine(1.20 * qty);
                        break;
                    case "sweets":
                        Console.WriteLine(1.45 * qty);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.60 * qty);
                        break;
                    default:
                        price = 99999 * qty;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.40 * qty);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * qty);
                        break;
                    case "beer":
                        Console.WriteLine(1.15 * qty);
                        break;
                    case "sweets":
                        Console.WriteLine(1.30 * qty);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.50 * qty);
                        break;
                    default:
                        price = 99999 * qty;
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.45 * qty);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * qty);
                        break;
                    case "beer":
                        Console.WriteLine(1.10 * qty);
                        break;
                    case "sweets":
                        Console.WriteLine(1.35 * qty);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.55 * qty);
                        break;
                    default:
                        price = 99999 * qty;
                        break;
                }
            }
        }
    }
}
