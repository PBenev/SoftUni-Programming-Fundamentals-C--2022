using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string numOperator = Console.ReadLine();

            //calculations and print
            string oddOrEven = "";

            if (numOperator == "+")
            {
                if ((number1+number2) % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
            }
            else if (numOperator == "-")
            {
                if ((number1 - number2) % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
            }
            else if (numOperator == "*")
            {
                if ((number1 * number2) % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
            }

            if (number2 != 0)
            {
                switch (numOperator)
                {
                    case "+":
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2} - {oddOrEven}");
                        break;
                    case "-":
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2} - {oddOrEven}");
                        break;
                    case "*":
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2} - {oddOrEven}");
                        break;
                    case "/":
                        Console.WriteLine($"{number1} / {number2} = {Convert.ToDouble(number1) / Convert.ToDouble(number2):F2}");
                        break;
                    case "%":
                        Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }
        }
    }
}
