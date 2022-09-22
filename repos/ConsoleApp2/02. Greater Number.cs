using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int firstInt = int.Parse(Console.ReadLine());
            int SecondInt = int.Parse(Console.ReadLine());

            //Print
            if(firstInt>=SecondInt)
            { Console.WriteLine(firstInt); } else
            { Console.WriteLine(SecondInt); }
        }
    }
}
