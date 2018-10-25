using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
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
            List<int> mixedList = new List<int>();

            while (firstList.Count != 0 && secondList.Count != 0)
            {
                mixedList.Add(firstList[0]);
                mixedList.Add(secondList[secondList.Count - 1]);
                firstList.RemoveAt(0);
                secondList.RemoveAt(secondList.Count - 1);

            }

            int startNumber = 0;
            int endNumber = 0;

            if (firstList.Count != 0)
            {
                startNumber = Math.Min(firstList[0], firstList[1]);
                endNumber = Math.Max(firstList[0], firstList[1]);
            }
            else
            {
                startNumber = Math.Min(secondList[0], secondList[1]);
                endNumber = Math.Max(secondList[0], secondList[1]);
            }

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] <=startNumber || mixedList[i]>=endNumber)
                {
                    mixedList.RemoveAt(i);
                    i--;
                }
            }

            mixedList.Sort();

            Console.WriteLine(string.Join(' ',mixedList));


        }
    }
}
