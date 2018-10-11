using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int n  = int.Parse(Console.ReadLine());
           var firstResult = new int[n];
           var secondResult = new int[n];

            for (int i = 0; i < n; i++)
            {
                var currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    firstResult[i] = currentArray[0];
                    secondResult[i] = currentArray[1];
                }
                else
                {
                    firstResult[i] = currentArray[1];
                    secondResult[i] = currentArray[0];
                }
            }
            Console.WriteLine(string.Join(' ',firstResult));
            Console.WriteLine(string.Join(' ',secondResult));
        }
    }
}
