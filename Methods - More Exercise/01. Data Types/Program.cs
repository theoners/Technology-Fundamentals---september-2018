using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType=="int")
            {
                int number = int.Parse(Console.ReadLine());
                Calculate(number);
            }
            else if (dataType=="real")
            {
                double number = double.Parse(Console.ReadLine());
                Calculate(number);
            }
            else if (dataType=="string")
            {
                string text = Console.ReadLine();
                Calculate(text);
            }
        }

        private static void Calculate(string text)
        {
            Console.WriteLine("$"+text+"$");
        }

        private static void Calculate(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:F2}");
        }

        private static void Calculate(int number)
        {
            Console.WriteLine(number*2);
        }
    }
}
