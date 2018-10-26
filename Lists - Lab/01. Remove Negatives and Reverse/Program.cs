using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .Where(x => x >= 0)
                                .ToList();
            numbers.Reverse();
            if (numbers.Count!=0)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
           
        }
    }
}
