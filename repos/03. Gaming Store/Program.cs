using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double gamePrice = 0;
            double spent = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time")
                {
                    break;
                }

                switch (input)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (balance == gamePrice)
                {
                    balance = 0;
                    Console.WriteLine("Out of money");
                    break;
                }
                if (gamePrice > balance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Bought {input}");
                    balance -= gamePrice;
                    spent += gamePrice;
                }
            }
            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:F2}");
            }
            
        }
    }
}
