using System;

namespace _04._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(meter/1000):F2}");
        }
    }
}
