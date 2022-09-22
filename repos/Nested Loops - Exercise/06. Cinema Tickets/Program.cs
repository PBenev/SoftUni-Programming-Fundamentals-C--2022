using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int student = 0;
            int standard = 0;
            int kid = 0;
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;

            while (movie != "Finish")
            {
                student = 0;
                standard = 0;
                kid = 0;
                double availableSeats = double.Parse(Console.ReadLine());

                for (double i = availableSeats; i > 0; i--)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student":
                            student++;
                            totalStudent++;
                            break;
                        case "standard":
                            standard++;
                            totalStandard++;
                            break;
                        case "kid":
                            kid++;
                            totalKid++;
                            break;
                    }
                }
                Console.WriteLine($"{movie} - {((student+standard+kid)/availableSeats)*100:F2}% full.");
                movie = Console.ReadLine();
            }
            double totalTickets = totalKid + totalStandard + totalStudent;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(totalStudent/totalTickets)*100:F2}% student tickets.");
            Console.WriteLine($"{(totalStandard / totalTickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(totalKid / totalTickets) * 100:F2}% kids tickets.");
        }
    }
}
