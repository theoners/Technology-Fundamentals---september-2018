using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToList();
            List<int> secondList = Console.ReadLine()
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToList();
            var result = new List<int>();
            while (firstList.Count!=0 && secondList.Count!=0)
            {
                result.Add(firstList[0]);
                result.Add(secondList[0]);
                firstList.RemoveAt(0);
                secondList.RemoveAt(0);
            }

            if (firstList.Count!=0)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
