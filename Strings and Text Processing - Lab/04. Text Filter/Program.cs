using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWord.Length; i++)
            {
                string currentWord = new string('*', bannedWord[i].Length);

                text = text.Replace(bannedWord[i], currentWord);
            }

            Console.WriteLine(text);
        }
    }
}
