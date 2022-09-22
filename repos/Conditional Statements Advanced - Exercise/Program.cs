using System;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string projectionType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int columnsCount = int.Parse(Console.ReadLine());

            //print
            switch (projectionType)
            {
                case "Premiere":
                    Console.WriteLine($"{(rowsCount*columnsCount)*12.00:F2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{(rowsCount * columnsCount) * 7.50:F2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{(rowsCount * columnsCount) * 5.00:F2} leva");
                    break;
            }
        }
    }
}
