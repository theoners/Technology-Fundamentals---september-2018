using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();

            while (command[0]!="end")
            {
                if (command[0]=="Add")
                {
                    listOfWagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i]+passengers<=maxCapacityOfWagon)
                        {
                            listOfWagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ',listOfWagons));
        }
    }
}
