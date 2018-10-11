using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = Console.ReadLine().Split(' ');

            var reverseTexts = texts.Reverse();

            Console.WriteLine(string.Join(' ',reverseTexts));
        }
    }
}
