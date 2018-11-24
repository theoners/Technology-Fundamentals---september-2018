using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<string> reverseWord = new List<string>();

            while (true)
            {
                string word = Console.ReadLine();
                if (word=="end")
                {
                    break;
                }
                words.Add(word);
                var reversedWord = "";
                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversedWord += word[i];

                }
                reverseWord.Add(reversedWord);
            }

            for (int i = 0; i < reverseWord.Count; i++)
            {
                Console.WriteLine($"{words[i]} = {reverseWord[i]}");
            }
        }
    }
}
