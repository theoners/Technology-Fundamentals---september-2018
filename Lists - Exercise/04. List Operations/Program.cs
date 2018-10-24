using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split();

            while (commands[0]!="End")
            {
                if (commands[0]=="Add")
                {
                    listOfInt.Add(int.Parse(commands[1]));
                }

                else if (commands[0]=="Insert")
                {
                    if (int.Parse(commands[2])>=0 && int.Parse(commands[2])<listOfInt.Count)
                    {
                        listOfInt.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }

                else if (commands[0]=="Remove")
                {
                    if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < listOfInt.Count)
                    {
                        listOfInt.RemoveAt(int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                       listOfInt= ShiftLeft(listOfInt, int.Parse(commands[2]));
                    }
                    else if (commands[1] == "right")
                    {
                        listOfInt = ShiftRight(listOfInt, int.Parse(commands[2]));
                    }
                }

                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ',listOfInt));
        }

        private static List<int> ShiftRight(List<int> listOfInt, int steps)
        {
            var shiftedList = new List<int>();

            for (int i = listOfInt.Count-(steps % listOfInt.Count); i < listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            for (int i = 0; i < listOfInt.Count - (steps % listOfInt.Count); i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            return shiftedList;
        }

        private static List<int> ShiftLeft(List<int> listOfInt, int steps)
        {
            var shiftedList = new List<int>();

            for (int i = steps%listOfInt.Count; i < listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            for (int i = 0; i < steps % listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            return shiftedList;
        }
    }
}
