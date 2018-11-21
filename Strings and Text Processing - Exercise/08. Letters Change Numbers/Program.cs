using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double sum = 0;
            Regex regex = new Regex(@"[A-Za-z].+?[A-Za-z]");

            var matches = regex.Matches(text);
            List<string> input = new List<string>();
            foreach (Match match in matches)
            {
                input.Add(match.Value);
            }

            for (int i = 0; i < input.Count; i++)
            {
                string currentText = input[i];
                var firstLetter = currentText[0];
                var lastLetter = currentText[currentText.Length - 1];
                string middle = currentText.Substring(1, currentText.Length - 2);
                string numberAstext = string.Empty;
                double result = 0;
                for (int k = 0; k < middle.Length; k++)
                {
                    if (middle[k] >= 48 && middle[k] <= 57)
                    {
                        numberAstext += middle[k];
                    }
                }
                double number = double.Parse(numberAstext);
                if (firstLetter >= 65 && firstLetter <= 90 && number != 0)
                {
                    result = number / (firstLetter - 64);
                }
                else if (number != 0)
                {
                    result = number * (firstLetter - 96);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    result -= lastLetter - 64;
                }
                else
                {
                    result += lastLetter - 96;
                }

                sum += result;
            }
            Console.WriteLine($"{sum:F2}");

        }
    }
}
