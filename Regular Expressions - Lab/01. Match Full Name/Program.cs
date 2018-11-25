using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b([A-Z]{1}[a-z]{1,}) [A-Z]{1}[a-z]{1,}\b");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }
        }
    }
}
