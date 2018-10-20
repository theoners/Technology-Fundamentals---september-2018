using System;

namespace _10._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = repeatString(text, count);

            Console.WriteLine(result);
        }

        private static string repeatString(string text, int count)
        {
            string repeatText = text;

            for (int i = 1; i < count; i++)
            {
                repeatText += text;
            }

            return repeatText;
        }
    }
}
