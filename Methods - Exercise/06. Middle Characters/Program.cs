using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string middleChar = FindMiddleChar(input);

            Console.WriteLine(middleChar);
        }

        private static string FindMiddleChar(string text)
        {
            if (text.Length%2==1)
            {
                return text[text.Length / 2].ToString(); ;
            }
            else
            {
                return  (""+text[(text.Length / 2)-1] + text[(text.Length / 2)]).ToString();
            }
        }
    }
}
