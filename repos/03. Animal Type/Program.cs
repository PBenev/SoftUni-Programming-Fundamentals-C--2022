using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string specie = Console.ReadLine();

            //print
            if(specie == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if(specie == "crocodile" || specie == "tortoise" || specie == "snake")
            {
                Console.WriteLine("reptile");
            } else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
