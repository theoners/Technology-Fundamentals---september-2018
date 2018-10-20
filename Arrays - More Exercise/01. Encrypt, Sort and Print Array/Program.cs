using System;
using System.Collections.Generic;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = int.Parse(Console.ReadLine());
            SortedDictionary<int, string> nameCode = new SortedDictionary<int, string>();
            int sum = 0;

            for (int i = 0; i < lineNumber; i++)
            {
                string name = Console.ReadLine();

                for (int k = 0; k < name.Length; k++)
                {
                    if (name[k]=='a' || name[k] == 'e' || name[k] == 'i' || name[k] == 'o' || name[k] == 'u' 
                        || name[k] == 'A' || name[k] == 'E' || name[k] == 'I' || name[k] == 'O' || name[k] == 'U')
                    {
                        sum += (int)name[k] * name.Length;
                    }
                    else
                    {
                        sum += (int)name[k] / name.Length;
                    }
                }

                nameCode.Add(sum, name);
                sum = 0;
            }

            foreach (var kvp in nameCode)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
