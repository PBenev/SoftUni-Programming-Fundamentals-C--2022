using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            int totalPPL = 0;

            double goToMusala = 0;
            double goToMonblan = 0;
            double goToKilimandjaro = 0;
            double goToK2 = 0;
            double goToEverest = 0;

            for (int i = 0; i < groupCount; i++)
            {
                int cntGroupMembers = int.Parse(Console.ReadLine());
                if (cntGroupMembers <= 5)
                {
                    goToMusala = goToMusala + cntGroupMembers;
                }
                else if (cntGroupMembers >= 6 && cntGroupMembers <= 12)
                {
                    goToMonblan = goToMonblan + cntGroupMembers;
                }
                else if (cntGroupMembers >= 13 && cntGroupMembers <= 25)
                {
                    goToKilimandjaro = goToKilimandjaro+cntGroupMembers;
                }
                else if (cntGroupMembers >= 26 && cntGroupMembers <= 40)
                {
                    goToK2 = goToK2 + cntGroupMembers;
                }
                else
                {
                    goToEverest = goToEverest +cntGroupMembers;
                }
                totalPPL = totalPPL + cntGroupMembers;
            }
            Console.WriteLine($"{goToMusala / totalPPL*100:F2}%");
            Console.WriteLine($"{goToMonblan / totalPPL * 100:F2}%");
            Console.WriteLine($"{goToKilimandjaro / totalPPL * 100:F2}%");
            Console.WriteLine($"{goToK2 / totalPPL * 100:F2}%");
            Console.WriteLine($"{goToEverest / totalPPL * 100:F2}%");
        }
    }
}
