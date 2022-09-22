using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int initialPoints = int.Parse(Console.ReadLine());

            //bonus points
            double bonusPoints = 0.0;

            if (initialPoints<=100)
            {
                bonusPoints = 5;
            }
            else if (initialPoints > 100 && initialPoints <= 1000)
            {
                bonusPoints = (20.0 / 100.0)*initialPoints;
            }
            else if (initialPoints > 1000)
            {
                bonusPoints = (10.0 / 100.0) * initialPoints;
            }

            if (initialPoints % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (initialPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            //print
            Console.WriteLine(bonusPoints);
            Console.WriteLine(initialPoints+bonusPoints);
        }
    }
}
