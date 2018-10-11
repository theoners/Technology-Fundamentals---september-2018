using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            int lastIndex = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count>maxCount)
                {
                    maxCount = count;
                    lastIndex = i;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(numbers[lastIndex]+" ");
            }
            
        }
    }
}
