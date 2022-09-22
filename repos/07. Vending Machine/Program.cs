using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double itemprice = 0;
            bool validProduct = true;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                if (double.Parse(input) == 0.1 || double.Parse(input) == 0.2 || double.Parse(input) == 0.5 || double.Parse(input) == 1 || double.Parse(input) == 2)
                {
                    sum += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Change: {sum:F2}");
                    break;
                }

                switch (input)
                {
                    case "Nuts":
                        itemprice = 2.0;
                        validProduct = true;
                        break;
                    case "Water":
                        itemprice = 0.7;
                        validProduct = true;
                        break;
                    case "Crisps":
                        itemprice = 1.5;
                        validProduct = true;
                        break;
                    case "Soda":
                        itemprice = 0.8;
                        validProduct = true;
                        break;
                    case "Coke":
                        itemprice = 1.0;
                        validProduct = true;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        validProduct = false;
                        break;
                }
                if (validProduct && itemprice <= sum)
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    sum -= itemprice;
                }
                else if (validProduct && itemprice > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}
