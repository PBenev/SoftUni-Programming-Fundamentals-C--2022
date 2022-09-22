using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //print
            if ((number < 100 && number != 0) || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
