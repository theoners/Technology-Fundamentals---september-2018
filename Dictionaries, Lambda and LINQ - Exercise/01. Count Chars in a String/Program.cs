using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var countChar = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar!=' ')
                {
                    if (!countChar.ContainsKey(currentChar))
                    {
                        countChar[currentChar] = 1;
                    }
                    else
                    {
                        countChar[currentChar]++;
                    }
                }
            }

            foreach (var kvp in countChar)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
