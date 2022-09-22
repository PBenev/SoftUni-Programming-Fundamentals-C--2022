using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());

            int daysSpend = 0;
            int totaldays = 0;
            string previousAction = "";

            while (moneyNeeded > moneyAvailable)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                totaldays++;

                if (action == "save")
                {
                    moneyAvailable += amount;
                    daysSpend = 0;
                }
                else
                {
                    if (previousAction == "" || previousAction == "spend")
                    {
                        daysSpend++;
                        if (daysSpend == 5)
                        {
                            Console.WriteLine("You can't save the money.");
                            Console.WriteLine(totaldays);
                            break;
                        }
                    }
                    if(amount > moneyAvailable)
                    {
                        moneyAvailable = 0;
                    }
                    else
                    {
                        moneyAvailable -= amount;
                    }

                }
                if (moneyAvailable >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {totaldays} days.");
                    break;
                }
            }
        }
    }
}
