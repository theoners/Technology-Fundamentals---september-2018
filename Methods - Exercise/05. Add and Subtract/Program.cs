using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumFirstTwoNumbers(firstNumber,secondNumber);
            int result = SubstractThirdNumber(sum,thirdNumber);

            Console.WriteLine(result);

        }

        private static int SubstractThirdNumber(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }

        private static int SumFirstTwoNumbers(int firstNumber,int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }
    }
}
