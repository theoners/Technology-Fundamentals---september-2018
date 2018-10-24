using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').ToList();
            var result = new List<int>();
            string reverseArrayAstext = "";
            numbers.Reverse();

            foreach (var number in numbers)
            {
                reverseArrayAstext += number + " ";
            }

            result = reverseArrayAstext.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
