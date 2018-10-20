using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FIndTopNumber(number);
        }

        private static void FIndTopNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                int sum = 0;
                int counter = 0;
                string numberAsText = i.ToString();

                for (int k = 0; k < numberAsText.Length; k++)
                {
                   sum+= (int)numberAsText[k];
                }

                for (int l = 0; l < numberAsText.Length; l++)
                {
                    if (numberAsText[l]%2==1)
                    {
                        counter++;
                    }
                }
                if (sum % 8 == 0 && counter > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
