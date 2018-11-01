using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var judgeStatistics = new Dictionary<string, Dictionary<string, int>>();
            var individualStandings = new Dictionary<string, int>();
            int positions = 1;

            while (input != "no more time")
            {
                string[] line = input.Split(" -> ");
                string contest = line[1];
                string username = line[0];
                int points = int.Parse(line[2]);

                if (!judgeStatistics.ContainsKey(contest))
                {
                    judgeStatistics.Add(contest, new Dictionary<string, int>());
                }
                if (!judgeStatistics[contest].ContainsKey(username))
                {
                    judgeStatistics[contest].Add(username, points);
                }
                else if (judgeStatistics[contest][username] < points)
                {
                    judgeStatistics[contest][username] = points;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in judgeStatistics)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Count} participants");
                positions = 1;
                foreach (var user in kvp.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    
                    Console.WriteLine($"{positions++}. {user.Key} <::> {user.Value}");
                }

            }

            foreach (var kvp in judgeStatistics)
            {
                foreach (var users in kvp.Value)
                {
                    if (!individualStandings.ContainsKey(users.Key))
                    {
                        individualStandings.Add(users.Key, users.Value);
                    }
                    else
                    {
                        individualStandings[users.Key] += users.Value;
                    }
                }
            }

            Console.WriteLine("Individual standings:");
            positions = 1;
            foreach (var user in individualStandings.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                
                Console.WriteLine($"{positions++}. {user.Key} -> {user.Value}");
            }
        }
    }
}
