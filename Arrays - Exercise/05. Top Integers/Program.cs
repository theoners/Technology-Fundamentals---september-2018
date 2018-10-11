using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTopInt = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i+1; k < array.Length; k++)
                {
                    if (array[i]<=array[k])
                    {
                        isTopInt = false;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(array[i] + " ");
                }

                isTopInt = true;
                
            }
        }
    }
}
