using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMinus = 0;
            for (int i = 0; i < 3; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }

                countMinus=FindSign(number,countMinus);
            }

            if (countMinus%2==0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        private static int FindSign(double number, int counter)
        {
            if (number<0)
            {
                counter++;
            }

            return counter;
        }
    }
}
