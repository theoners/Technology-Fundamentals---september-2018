using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[>]{2}(.+)[<]{2}([0-9]+([\.][0-9]+)?)!([0-9]+)");
            List<string> furnitures = new List<string>();
            double sum = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input=="Purchase")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string furnitereName = match.Groups[1].ToString();
                    string price = match.Groups[2].ToString();
                    string quantity = match.Groups[4].ToString();
                    furnitures.Add(furnitereName);
                    double currentSum = double.Parse(price) * double.Parse(quantity);
                    sum += currentSum;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
