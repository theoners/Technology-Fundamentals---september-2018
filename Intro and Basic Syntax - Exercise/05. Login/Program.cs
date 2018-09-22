using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            char[] array = username.ToCharArray();
            Array.Reverse(array);
            string reverseUsername = new string(array);

            for (int i = 0; i < 4; i++)
            {
                password = Console.ReadLine();
                if (password==reverseUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (i==3)
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
