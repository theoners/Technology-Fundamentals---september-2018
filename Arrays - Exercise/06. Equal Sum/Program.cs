using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int index = 0;
            while (index!=array.Length)
            {
                for (int i = 0; i < index; i++)
                {
                    leftSum += array[i];
                }

                for (int i = array.Length - 1; i > index; i--)
                {
                    rightSum += array[i];
                }

                if (rightSum==leftSum)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
                leftSum = 0;
                rightSum = 0;
            }

            Console.WriteLine("no");
            
        }
    }
}
