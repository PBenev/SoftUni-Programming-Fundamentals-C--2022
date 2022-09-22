using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = n; i > 0; i--)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulsCnt = int.Parse(Console.ReadLine());

                double totalPrice = (days * capsulsCnt) * capsulePrice;

                Console.WriteLine($"The price for the coffee is: ${totalPrice:F2}");
                sum += totalPrice;
            }
            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
