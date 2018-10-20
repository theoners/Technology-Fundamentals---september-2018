using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num>=3)
            {
                int[] tribonacciNumbers = new int[num];
                tribonacciNumbers[0] = 1;
                tribonacciNumbers[1] = 1;
                tribonacciNumbers[2] = 2;

                for (int i = 3; i < num; i++)
                {
                    tribonacciNumbers[i] = tribonacciNumbers[i - 1] + tribonacciNumbers[i - 2] + tribonacciNumbers[i - 3];
                }

                Console.WriteLine(string.Join(' ', tribonacciNumbers));
            }
           

            if (num==1)
            {
                Console.WriteLine(1);
            }
            else if (num==2)
            {
                Console.Write(1+" ");
                Console.WriteLine(1);
            }
        }
    }
}
