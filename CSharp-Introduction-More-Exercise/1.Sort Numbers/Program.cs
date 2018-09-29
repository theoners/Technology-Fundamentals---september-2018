using System;

namespace _1.Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = new int[3];

            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(input);
            Array.Reverse(input);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(input[i]);
            }
            
        }
    }
}
