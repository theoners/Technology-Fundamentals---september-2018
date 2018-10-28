using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymsDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();
                if (!synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary.Add(word,new List<string>());
                    synonymsDictionary[word].Add(synonyms);
                }
                else
                {
                    synonymsDictionary[word].Add(synonyms);
                }
            }

            foreach (var word in synonymsDictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
