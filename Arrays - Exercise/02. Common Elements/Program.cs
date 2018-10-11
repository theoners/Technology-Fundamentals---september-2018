using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTexts = Console.ReadLine().Split();
            var secondTexts = Console.ReadLine().Split();
            string sameText = "";

            for (int i = 0; i < secondTexts.Length; i++)
            {
                for (int k = 0; k < firstTexts.Length; k++)
                {
                    if (secondTexts[i]==firstTexts[k])
                    {
                        sameText += secondTexts[i] + " ";
                    }
                }
            }

            Console.WriteLine(sameText);
        }
    }
}
