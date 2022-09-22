using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadsets = 0;
            int brokenMice = 0;
            int brokenKeyboards = 0;
            int brokenDisplays = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2 == 0)
                {
                    brokenHeadsets++;
                }
                if (i%3 == 0)
                {
                    brokenMice++;
                }
                if (i%6 == 0)
                {
                    brokenKeyboards++;
                    if (brokenKeyboards % 2 == 0 && brokenKeyboards > 0)
                    {
                        brokenDisplays++;
                    }
                }
                
            }
            Console.WriteLine($"Rage expenses: {brokenDisplays*displayPrice+brokenHeadsets*headsetPrice+brokenKeyboards*keyboardPrice+brokenMice*mousePrice:F2} lv.");
        }
    }
}
