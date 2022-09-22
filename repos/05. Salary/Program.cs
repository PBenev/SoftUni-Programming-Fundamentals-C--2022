using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int penalty = 0;

            for (int i = 0; i < tabs; i++)
            {
                string penaltySite = Console.ReadLine();

                switch (penaltySite)
                {
                    case "Facebook":
                        penalty = 150;
                        break;
                    case "Instagram":
                        penalty = 100;
                        break;
                    case "Reddit":
                        penalty = 50;
                        break;
                    default:
                        penalty = 0;
                        break;
                }

                salary = salary - penalty;
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
