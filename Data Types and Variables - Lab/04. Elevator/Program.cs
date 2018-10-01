using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double cours = numberOfPeople / capacity;

            Console.WriteLine($"{Math.Ceiling(cours)}");
        }
    }
}
