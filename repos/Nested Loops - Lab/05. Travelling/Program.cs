using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while(destination != "End")
            {
                double moneyATM = 0;
                double moneyNeeded = double.Parse(Console.ReadLine());
                while(moneyATM < moneyNeeded)
                {
                    moneyATM += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
