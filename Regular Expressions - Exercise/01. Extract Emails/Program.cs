using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\(?(?<=\s|^)[A-Za-z0-9]+(\.|-|_)*[A-Za-z0-9]+@[a-z]+(\.|-|[a-z])*\.([a-z])+");
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
