using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationsCount =int.Parse(Console.ReadLine());
            int[] rotatedArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; ++i)
            {
                rotatedArray[(i + numbers.Length - rotationsCount%numbers.Length) % numbers.Length] = numbers[i];
            }

            for (int j = 0; j < numbers.Length; ++j)
            {
                Console.Write(rotatedArray[j] + " ");
            }


        }
    }
}
