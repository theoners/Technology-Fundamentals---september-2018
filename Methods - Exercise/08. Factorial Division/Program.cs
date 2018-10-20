using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = FindFactorial(firstNumber)/FindFactorial(secondNumber);

            Console.WriteLine($"{result:F2}");
        }

        private static double FindFactorial(int number)
        {
            double factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
