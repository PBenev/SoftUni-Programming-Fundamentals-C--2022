using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int lgth = username.Length-1;
            string password = "";
            int cntAttempts = 1;

            for (int i = lgth; i >= 0; i--)
            {
                password = password + username[i];
            }

            while (true)
            {
                string userinput = Console.ReadLine();
                if (password != userinput && cntAttempts < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    cntAttempts++;
                }
                else if (password != userinput && cntAttempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
