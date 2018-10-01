using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecialNumber = false;

            for (int i = 1; i <=number; i++)
            {
                Console.Write($"{i} -> ");
                int curerntNumber = i;
                while (curerntNumber!=0)
                {
                    int lastDIgit = curerntNumber % 10;
                    curerntNumber /= 10;
                    sum += lastDIgit;
                }
                if (sum==5 || sum==7 || sum==11)
                {
                    isSpecialNumber = true;
                }
                else
                {
                    isSpecialNumber = false;
                }
                Console.WriteLine(isSpecialNumber);
                sum = 0;
            }
        }
    }
}
