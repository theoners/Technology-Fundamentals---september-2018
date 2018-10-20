using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            string numberAstext = number.ToString();

            
            int result = GetMultipleOfEvenAndOdds(numberAstext);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(string numberAstext)
        {
            int evenDigitsSum = GetSumOfEvenAndOddDigits(numberAstext, 0);
            int oddDigitSSum = GetSumOfEvenAndOddDigits(numberAstext, 1);

            return evenDigitsSum * oddDigitSSum;
        }

        private static int GetSumOfEvenAndOddDigits(string numberAstext,int factor)
        {
            int sum = 0;
            for (int i = 0; i < numberAstext.Length; i++)
            {
                int digit = numberAstext[i]-48;

                if (digit%2==factor)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}
