using System;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split();

            while (commands[0]!="end")
            {
                if (commands[0]=="Delete")
                {
                    listOfInt.RemoveAll(x => x == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    listOfInt.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(' ',listOfInt));
        }
    }
}
