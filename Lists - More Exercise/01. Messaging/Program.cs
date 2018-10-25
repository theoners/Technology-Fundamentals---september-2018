using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string message = Console.ReadLine();
            List<char> messageAsChar = new List<char>();
            var sumOfNumbers = new List<int>();

            for (int i = 0; i < message.Length; i++)
            {
                messageAsChar.Add(message[i]);
            }

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int sumOfAlldigits = 0;
                for (int digit = 0; digit < listOfNumbers[i].Length; digit++)
                {
                    sumOfAlldigits += listOfNumbers[i][digit]-48;
                }

                int currentCharIndex = sumOfAlldigits % message.Length;
                Console.Write(messageAsChar[currentCharIndex]);
                messageAsChar.RemoveAt(currentCharIndex);
                
            }
            Console.WriteLine();
        }
    }
}
