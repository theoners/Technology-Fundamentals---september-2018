using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var softUniParking = new Dictionary<string, string>();


            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();


                if (input[0]=="register")
                {
                    string userName = input[1];
                    string licensePlateNumber = input[2];

                    if (!softUniParking.ContainsKey(userName))
                    {
                        softUniParking.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered { licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {softUniParking[userName]}");
                    }
                }
                else
                {
                    string userName = input[1];

                    if (!softUniParking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        softUniParking.Remove(userName);
                    }
                }
            }

            foreach (var register in softUniParking)
            {
                Console.WriteLine($"{register.Key} => {register.Value}");
            }
        }
    }
}
