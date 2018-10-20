using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SmallestOfThreeNumbers(firstNumber,secondNumber,thirdNumber);
        }

        private static void SmallestOfThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = Math.Min(firstNumber, secondNumber);

            Console.WriteLine(Math.Min(result,thirdNumber));
        }
    }
}
