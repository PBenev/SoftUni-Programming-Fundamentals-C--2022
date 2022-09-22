using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            //print
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.50 *qty);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.20 * qty);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.85 * qty);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.45 * qty);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 2.70 * qty);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.50 * qty);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 3.85 * qty);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.70 * qty);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.25 * qty);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.90 * qty);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.60 * qty);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 3 * qty);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.60 * qty);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 4.20 * qty);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            } else
            {
                Console.WriteLine("error");
            }
        }
    }
}
