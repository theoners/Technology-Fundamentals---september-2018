using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            var companyUsers = new SortedDictionary<string, List<string>>();

            while (input[0]!="End")
            {
                string company = input[0];
                string userId = input[1];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers.Add(company, new List<string>());
                    companyUsers[company].Add(userId);
                }
                else
                {
                    if (!companyUsers[company].Contains(userId))
                    {
                        companyUsers[company].Add(userId);
                    }
                }

                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var kvp in companyUsers)
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
