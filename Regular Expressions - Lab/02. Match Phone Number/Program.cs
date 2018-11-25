using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\+359)( |-)[2]\2[0-9]{3}\2[0-9]{4}\b");

            var matches = regex.Matches(input);

            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
