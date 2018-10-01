using System;

namespace _10._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 0;
            bool isSpecialNumber = false;
            for (int curentNUmber = 1; curentNUmber <= number; curentNUmber++)
            {
                temp = curentNUmber;
                while (curentNUmber > 0)
                {
                    sum += curentNUmber % 10;
                    curentNUmber = curentNUmber / 10;
                }

                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{temp} -> {isSpecialNumber}");

                sum = 0;
                curentNUmber = temp;
            }

        }
    }
}
