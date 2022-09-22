using System;

namespace For_Loop___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                string num = i.ToString();
                int lastIndex = num.Length-1;

                if (num.EndsWith("7"))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
