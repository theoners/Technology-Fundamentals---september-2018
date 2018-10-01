using System;

namespace _05._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(pounds*1.31):F3}");
        }
    }
}
