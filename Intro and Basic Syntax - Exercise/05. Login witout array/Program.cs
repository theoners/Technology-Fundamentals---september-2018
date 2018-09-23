using System;

namespace _05._Login_witout_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            string reverseUsername = "";

            for (int i = username.Length-1; i >= 0; i--)
            {
                reverseUsername += username[i];
            }

            for (int i = 0; i < 4; i++)
            {
                password = Console.ReadLine();
                if (password == reverseUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }

                }
            }
        }
    }
}
