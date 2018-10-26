using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            if (numbers.Count!=3 && numbers.Count>1)
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else if (numbers.Count==3)
            {
                numbers[0] += numbers[2];
                numbers.RemoveAt(2);
            }
            

            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}
