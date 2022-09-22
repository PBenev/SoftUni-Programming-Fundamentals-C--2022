using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int cntMoneyReceived = 0;
            int cntToysReceived = 0;

            double initialMoney = 0;

            double totalMoneyFromBdays = 0;
            double totalMoneyFromToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2 == 0)
                {
                    initialMoney += 10;
                    totalMoneyFromBdays = totalMoneyFromBdays + initialMoney -1;
                }
                else
                {
                    totalMoneyFromToys = totalMoneyFromToys + toyPrice;
                }
            }
            if (totalMoneyFromBdays+totalMoneyFromToys >= washerPrice)
            {
                Console.WriteLine($"Yes! {(totalMoneyFromBdays + totalMoneyFromToys) - washerPrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice - (totalMoneyFromBdays + totalMoneyFromToys):F2}");
            }
        }
    }
}
