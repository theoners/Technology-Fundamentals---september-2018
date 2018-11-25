using System;
using System.Text.RegularExpressions;

namespace _04._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            var matches = regex.Matches(input);

            Console.WriteLine(string.Join(' ',matches));
        }
    }
}
