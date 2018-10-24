using System;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequenceOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (sequenceOfNumbers.Contains(bombNumber[0]))
            {
                int bombIndex = sequenceOfNumbers.IndexOf(bombNumber[0]);

                if (bombIndex-bombNumber[1]>=0)
                {
                    sequenceOfNumbers.RemoveRange(bombIndex - bombNumber[1], bombNumber[1]);
                    bombIndex = sequenceOfNumbers.IndexOf(bombNumber[0]);
                }
                else
                {
                    sequenceOfNumbers.RemoveRange(0, bombIndex);
                    bombIndex = sequenceOfNumbers.IndexOf(bombNumber[0]);
                }

                if (bombIndex + bombNumber[1] < sequenceOfNumbers.Count)
                {
                    sequenceOfNumbers.RemoveRange(bombIndex, bombNumber[1] + 1);
                    bombIndex = sequenceOfNumbers.IndexOf(bombNumber[0]);
                }
                else
                {
                    sequenceOfNumbers.RemoveRange(bombIndex, sequenceOfNumbers.Count-bombIndex);
                    bombIndex = sequenceOfNumbers.IndexOf(bombNumber[0]);
                }
            }

            int sum = sequenceOfNumbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
