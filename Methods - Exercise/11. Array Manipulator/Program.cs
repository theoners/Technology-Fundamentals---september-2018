using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0]!="end")
            {
                if (command[0]=="exchange")
                {
                    if ((int.Parse(command[1]))>=array.Length || (int.Parse(command[1])) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                       array= Exchange(array, (int.Parse(command[1])));
                    }
                }
                else if (command[0] == "max")
                {
                    string oddOrEven = command[1];
                    int index = FindMaxOddEvenElement(array,oddOrEven);

                    if (index==-1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

                else if (command[0] == "min")
                {
                    string oddOrEven = command[1];
                    int index = FindMinOddEvenElement(array, oddOrEven);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (command[0] == "first")
                {
                    int numberCount = int.Parse(command[1]);
                    string oddOrEven = command[2];
                    if (numberCount>array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string oddOrEvenNumbers = FindFirsEvenOrOddNumbers(array, numberCount, oddOrEven);
                        if (oddOrEvenNumbers.Length==0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            oddOrEvenNumbers = oddOrEvenNumbers.TrimEnd(' ');
                            oddOrEvenNumbers = oddOrEvenNumbers.TrimEnd(',');
                            Console.WriteLine($"[{oddOrEvenNumbers}]");
                        }
                    }
                    
                }
                else if (command[0] == "last")
                {
                    int numberCount = int.Parse(command[1]);
                    string oddOrEven = command[2];
                    if (numberCount > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string oddOrEvenNumbers = FindLastEvenOrOddNumbers(array, numberCount, oddOrEven);
                        if (oddOrEvenNumbers.Length == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            oddOrEvenNumbers = oddOrEvenNumbers.TrimEnd(' ');
                            oddOrEvenNumbers = oddOrEvenNumbers.TrimEnd(',');
                            Console.WriteLine($"[{oddOrEvenNumbers}]");
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("["+string.Join(", ",array)+"]");
        }

        private static string FindLastEvenOrOddNumbers(int[] array, int numberCount, string oddOrEven)
        {
            string oddOrEvenNumbers = "";
            int factor = 1;
            if (oddOrEven == "even")
            {
                factor = 0;
            }

            for (int i = array.Length-1; i >=0; i--)
            {
                if (array[i] % 2 == factor && numberCount > 0)
                {
                    oddOrEvenNumbers = array[i] + ", "+oddOrEvenNumbers;
                    numberCount--;
                }
            }

            return oddOrEvenNumbers;
        }

        private static string FindFirsEvenOrOddNumbers(int[] array, int numberCount, string oddOrEven)
        {
            string oddOrEvenNumbers = "";
            int factor = 1;
            if (oddOrEven=="even")
            {
                factor = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==factor && numberCount>0)
                {
                    oddOrEvenNumbers += array[i] + ", ";
                    numberCount--;
                }
            }

            return oddOrEvenNumbers;
        }

        private static int FindMinOddEvenElement(int[] array, string oddOrEven)
        {
            int factor = 1;
            if (oddOrEven == "even")
            {
                factor = 0;
            }
            int minEvenOddIndex = -1;
            int minEvenOddNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == factor)
                {
                    if (minEvenOddNumber >= array[i])
                    {
                        minEvenOddNumber = array[i];
                        minEvenOddIndex = i;
                    }
                }
            }
            return minEvenOddIndex;
        }

        private static int FindMaxOddEvenElement(int[]array, string oddOrEven)
        {
            int factor = 1;
            if (oddOrEven=="even")
            {
                factor = 0;
            }
            int maxEvenOddIndex = -1;
            int maxEvenOddNumber = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == factor)
                {
                    if (maxEvenOddNumber <= array[i])
                    {
                        maxEvenOddNumber = array[i];
                        maxEvenOddIndex = i;
                    }
                }
            }
            return maxEvenOddIndex;
        }

        private static int[] Exchange(int[] array,int index)
        {
            int[] exchangedArray = new int[array.Length];
            int indexCounter = 0;
            if (index == array.Length-1)
            {
                return array;
            }
            for (int i = index+1; i < array.Length; i++)
            {
                exchangedArray[indexCounter] = array[i];
                indexCounter++;
            }
            for (int i = 0; i <= index; i++)
            {
                exchangedArray[indexCounter] = array[i];
                indexCounter++;
            }
            return exchangedArray;
        }
    }
}
