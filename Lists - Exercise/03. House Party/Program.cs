using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfGuests = new List<string>();
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[2]!="not")
                {
                    if (!listOfGuests.Contains(commands[0]))
                    {
                        listOfGuests.Add(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                }
                else
                {
                    if (listOfGuests.Contains(commands[0]))
                    {
                        listOfGuests.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }

            foreach (var name in listOfGuests)
            {
                Console.WriteLine(name);
            }

        }
    }
}
