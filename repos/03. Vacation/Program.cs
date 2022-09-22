using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double cntPpl = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    sum = 8.45 * cntPpl;
                }
                else if (type == "Business")
                {
                    sum = 10.90 * cntPpl;
                }
                else if (type == "Regular")
                {
                    sum = 15 * cntPpl;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    sum = 9.80 * cntPpl;
                }
                else if (type == "Business")
                {
                    sum = 15.60 * cntPpl;
                }
                else if (type == "Regular")
                {
                    sum = 20 * cntPpl;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    sum = 10.46 * cntPpl;
                }
                else if (type == "Business")
                {
                    sum = 16 * cntPpl;
                }
                else if (type == "Regular")
                {
                    sum = 22.50 * cntPpl;
                }
            }
            if (type == "Students")
            {
                if (cntPpl >= 30)
                {
                    sum = sum - (15.00 / 100.00) * sum;
                }
            }
            else if (type == "Business")
            {
                if (cntPpl >= 100)
                {
                    sum = sum - (sum / cntPpl) * 10;
                }
            }
            else if (type == "Regular")
            {
                if (cntPpl >= 10 && cntPpl <= 20)
                {
                    sum = sum - (5.00 / 100.00) * sum;
                }
            }

            Console.WriteLine($"Total price: {sum:F2}");
        }
    }
}
