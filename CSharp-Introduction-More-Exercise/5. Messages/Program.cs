using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLine = int.Parse(Console.ReadLine());
            int count = 0;
            char letter = 'a';
            var sortingArray = new string[26];

            for (int i = 2; i <= 9; i++)
            {
                sortingArray[count]= i.ToString();
                count++;
            }
            for (int i = 22; i <= 99; i+=11)
            {
                sortingArray[count] = i.ToString();
                count++;
            }
            for (int i = 222; i <= 999; i+=111)
            {
                sortingArray[count] = i.ToString();
                count++;
                if (i==777)
                {
                    sortingArray[count] = "7777";
                    count++;
                }
            }

            sortingArray[count] = "9999";

            Array.Sort(sortingArray);

            var code = new Dictionary<string, char>();

            for (int i = 0; i <= 25; i++)
            {
                code.Add(sortingArray[i], letter);
                letter++;
            }
            code.Add("0", ' ');

            string message = "";

            for (int i = 0; i < countLine; i++)
            {
                string codeLine = Console.ReadLine();
                code.TryGetValue(codeLine,out char oneLetter);
                message += ""+oneLetter;
            }
            Console.WriteLine(message);
        }
    }
}
