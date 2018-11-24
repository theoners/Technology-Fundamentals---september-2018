using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            Regex nameRegex = new Regex(@"[@][A-Za-z]+[|]");
            Regex ageRegex = new Regex(@"[#][0-9]+[*]");
            for (int i = 0; i < lineCount; i++)
            {
                string text = Console.ReadLine();
                var name = nameRegex.Match(text).ToString();
                var age = ageRegex.Match(text).ToString();
                name = name.Substring(1, name.Length - 2);
                age = age.Substring(1, age.Length - 2);

                Console.WriteLine($"{name} is {age} years old.");
            }
            
        }
    }
}
