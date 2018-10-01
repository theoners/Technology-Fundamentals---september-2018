using System;
using System.Numerics;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger fourthNumber = BigInteger.Parse(Console.ReadLine());

            BigInteger result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;

            Console.WriteLine(result);
        }
    }
}
