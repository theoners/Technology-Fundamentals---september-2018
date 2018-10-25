using System;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptedMessage = Console.ReadLine();
            List<char> messageAsChar = new List<char>();

            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                messageAsChar.Add(cryptedMessage[i]);
            }

            List<int> numbers = InsertAllNumbers(cryptedMessage);
            List<char> messageWithoutNumbers = RemoveNumbersFromString(messageAsChar);
            List<int> takeList = TakeEvenPositionNumber(numbers);
            List<int> skipList = TakeOddPositionNumber(numbers);
            List<char> message = new List<char>();


            for (int i = 0; i < takeList.Count; i++)
            {
                for (int k = 0; k < takeList[i]; k++)
                {
                    if (messageWithoutNumbers.Count != 0)
                    {
                        message.Add(messageWithoutNumbers[0]);
                        messageWithoutNumbers.RemoveAt(0);
                    }
                }

                for (int j = 0; j < skipList[i]; j++)
                {
                    if (messageWithoutNumbers.Count != 0)
                    {
                        messageWithoutNumbers.RemoveAt(0);
                    }
                }

                if (messageWithoutNumbers.Count==0)
                {
                    break;
                }
            }

            for (int i = 0; i < message.Count; i++)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();

        }

        private static List<char> RemoveNumbersFromString(List<char> cryptedMessage)
        {
            List<char> message = new List<char>();
            for (int i = 0; i < cryptedMessage.Count; i++)
            {
                char currentChar = cryptedMessage[i];
                if (currentChar < 48 || currentChar > 57)
                {
                    message.Add(currentChar);
                }
            }
            return message;
        }

        private static List<int> TakeOddPositionNumber(List<int> numbers)
        {
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 1)
                {
                    skipList.Add(numbers[i]);
                }
            }

            return skipList;
        }

        private static List<int> TakeEvenPositionNumber(List<int> numbers)
        {
            List<int> takeList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
            }

            return takeList;
        }

        private static List<int> InsertAllNumbers(string cryptedMessage)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                int currentChar = cryptedMessage[i];
                if (currentChar >= 48 && currentChar <= 57)
                {
                    numbers.Add(currentChar - 48);
                }
            }

            return numbers;
        }
    }
}
