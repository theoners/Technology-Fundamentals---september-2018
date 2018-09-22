using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes+30;

            int backHour = totalMinutes / 60;
            int backMinutes = totalMinutes % 60;

            if (backHour!=24)
            {
                Console.WriteLine($"{backHour}:{backMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{0}:{backMinutes:D2}");
            }

        }
    }
}
