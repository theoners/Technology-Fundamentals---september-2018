using System;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count!=0 && secondPlayerCards.Count!=0)
            {
                if (firstPlayerCards[0]>secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.RemoveAt(0);
                }
                else if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            if (firstPlayerCards.Count==0)
            {
                int secondPlayerCardsSum = secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCardsSum}");
            }
            else
            {
                int firstPlayerCardsSum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {firstPlayerCardsSum}");
            }
        }
    }
}
