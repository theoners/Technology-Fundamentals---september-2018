using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagon = int.Parse(Console.ReadLine());
            var peopleOnEachWagon = new int[countOfWagon];
            int sumOfPeople = 0;

            for (int i = 0; i < countOfWagon; i++)
            {
                peopleOnEachWagon[i] = int.Parse(Console.ReadLine());
                sumOfPeople += peopleOnEachWagon[i];
            }

            Console.WriteLine(string.Join(' ', peopleOnEachWagon));
            Console.WriteLine(sumOfPeople);
        }
    }
}
