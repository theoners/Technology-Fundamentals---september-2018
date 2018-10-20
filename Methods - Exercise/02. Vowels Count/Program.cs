using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            VowelsCounter(input);
        }

        private static void VowelsCounter(string input)
        {
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a' || input[i] == 'e' || input[i] == 'u' || input[i] == 'i' || input[i] == 'o')
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
