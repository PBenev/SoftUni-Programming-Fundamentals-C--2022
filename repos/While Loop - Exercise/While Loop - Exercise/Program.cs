using System;

namespace While_Loop___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int cntBooks = 0;

            while (true)
            {
                string searchBookName = Console.ReadLine();
                
                if(searchBookName == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {cntBooks} books.");
                    break;
                } else if(bookName != searchBookName)
                {
                    cntBooks++;
                }
                else
                {
                    Console.WriteLine($"You checked {cntBooks} books and found it.");
                    break;
                }
            }
        }
    }
}
