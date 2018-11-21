using System;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int rest = 0;
            if (secondNumber==0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                string currentNumber = (((int)firstNumber[i]-48) * secondNumber+rest).ToString();
                result +=currentNumber[currentNumber.Length-1];
                if (currentNumber.Length>1)
                {
                    rest = currentNumber[0]-48;
                }
                else
                {
                    rest = 0;
                }
            }
            if (rest!=0)
            {
                result += rest;
            }

            var reverseResult = result.Reverse();

            foreach (var number in reverseResult)
            {
                Console.Write(number);
            }
            Console.WriteLine();

        }
    }
}
