using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int[] array = new int[row];
            int[] currentArray = new int[row];
            array[0] = 1;

            for (int i = 0; i < row; i++)
            {
                
                for (int s = 0; s < array.Length; s++)
                {
                    currentArray[s] = array[s];
                }
                for (int k = 1; k <= i; k++)
                {
                    array[0] = 1;
                    array[k] = currentArray[k - 1] + currentArray[k];
                }
                for (int l = 0; l <= i; l++)
                {
                    Console.Write(array[l]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
