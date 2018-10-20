using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            while (number!="END")
            {
                bool isPalidrome = FindPalidromeInt(number);
                if (isPalidrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
        }

        private static bool FindPalidromeInt(string number)
        {
            bool isPlidrome = false;
            string reverseNumber = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                reverseNumber += number[i];
            }

            if (reverseNumber==number)
            {
                isPlidrome = true;
            }
            return isPlidrome;
            
        }
    }
}
