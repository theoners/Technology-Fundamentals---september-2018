using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            int[] fibonacciNumbers = new int[50];
            fibonacciNumbers[0] = 1;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i <= fibonacciNumber; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            Console.WriteLine(fibonacciNumbers[fibonacciNumber-1]);

            
        }
    }
}
