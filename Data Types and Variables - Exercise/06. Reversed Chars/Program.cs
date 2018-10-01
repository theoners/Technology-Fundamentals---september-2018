using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()+" "+Console.ReadLine() + " "+ Console.ReadLine();
            string result = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}
