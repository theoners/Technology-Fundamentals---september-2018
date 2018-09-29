using System;
using System.Collections.Generic;

namespace _5.Messages_with_Hints
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLine = int.Parse(Console.ReadLine());
            string message = "";
            
            for (int i = 0; i < countLine; i++)
            {
                string number = Console.ReadLine();
                if (number!="0")
                {
                    
                    int digitNumbers = number.Length;
                    int mainDigit = int.Parse(number) % 10;
                    int offset = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }
                    int letterIndex = offset + number.Length - 1 + 97;
                    char letter = (char)letterIndex;
                    message += letter;
                }
                else
                {
                    message += " ";
                }
                
            }
            Console.WriteLine(message);
        }
    }
}
