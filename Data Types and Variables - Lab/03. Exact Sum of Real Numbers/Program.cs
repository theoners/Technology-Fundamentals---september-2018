using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            decimal result = 0m;

            for (int i = 0; i < numberCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
