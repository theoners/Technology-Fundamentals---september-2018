using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool listIschange = false;

            while (input[0]!="end")
            {
                if (input[0]=="Contains")
                {
                    if (numbers.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (input[0] == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }

                else if(input[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                }

                else if (input[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }

                else if (input[0] == "Filter")
                {
                    string conditions = input[1];
                    int number = int.Parse(input[2]);
                    Filters(numbers, conditions , number);
                }

                else
                {
                    listIschange = true;
                    switch (input[0])
                    {
                        case "Add":
                            numbers.Add(int.Parse(input[1]));
                            break;
                        case "Remove":
                            numbers.Remove(int.Parse(input[1]));
                            break;
                        case "RemoveAt":
                            numbers.RemoveAt(int.Parse(input[1]));
                            break;
                        case "Insert":
                            numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                            break;
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (listIschange)
            {
                Console.WriteLine(string.Join(' ',numbers));
            }
        }

        private static void Filters(List<int> numbers, string conditions, int number)
        {
            if (conditions==">")
            {
                Console.WriteLine(string.Join(' ',numbers.Where(x=>x>number)));
            }
            else if (conditions=="<")
            {
                Console.WriteLine(string.Join(' ', numbers.Where(x => x < number)));
            }
            else if (conditions==">=")
            {
                Console.WriteLine(string.Join(' ', numbers.Where(x => x >= number)));
            }
            else if (conditions=="<=")
            {
                Console.WriteLine(string.Join(' ', numbers.Where(x => x <= number)));
            }
        }

        private static void PrintOddNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 == 1)));
        }

        private static void PrintEvenNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(' ',numbers.Where(x=>x%2==0)));
        }
    }
}
