using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesPerCurrentBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysToCompleteBook = int.Parse(Console.ReadLine());
            int hourToCompleteTheBook = pagesPerCurrentBook / pagesPerHour;
            int hoursReadingPerDay = hourToCompleteTheBook / daysToCompleteBook;
            Console.WriteLine(hoursReadingPerDay);
        }
    }
    }
