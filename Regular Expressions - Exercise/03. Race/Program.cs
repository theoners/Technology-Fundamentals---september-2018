using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            Dictionary<string, int> racerAndDistance = new Dictionary<string, int>();
            Regex racerRegex = new Regex(@"[A-Za-z]");
            Regex distanceRegex = new Regex(@"[0-9]");

            for (int i = 0; i < input.Length; i++)
            {
                racerAndDistance.Add(input[i], 0);
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end of race")
                {
                    break;
                }
                var nameMatches= racerRegex.Matches(line);
                var digitMatches = distanceRegex.Matches(line);
                string racerName = "";
                int distance = 0;
                foreach (Match match in nameMatches)
                {
                    racerName += match.Value;
                }
                foreach (Match digit in digitMatches)
                {
                    distance += int.Parse(digit.Value);
                }
                if (racerAndDistance.ContainsKey(racerName))
                {
                    racerAndDistance[racerName] += distance;
                }

            }
            int counter = 1;
            foreach (var racer in racerAndDistance.OrderByDescending(x=>x.Value))
            {
                if (counter==1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                    counter++;
                }
                else if (counter==2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                    break;
                }
            }
            
        }
    }
}
