﻿using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"};

            if (number>=1 && number<=7)
            {
                Console.WriteLine(dayOfWeek[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
