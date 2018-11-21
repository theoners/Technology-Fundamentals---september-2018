using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string currentTicket = input[i].Trim();
                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftSide = currentTicket.Substring(0, 10);
                    string rightSide = currentTicket.Substring(10);
                    Regex regex = new Regex(@"(#|@|\^|\$)\1{5,9}");
                    string leftMatch = regex.Match(leftSide).Value;
                    string rightMatch = regex.Match(rightSide).Value;
                    if (leftMatch == rightMatch && leftMatch.Length == 10 && leftMatch.Length!=0&& rightMatch.Length!=0)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {10}{currentTicket[0]} Jackpot!");
                    }
                    else if (leftMatch.Length != 0 && rightMatch.Length != 0)
                    {
                        var minMatch = Math.Min(leftMatch.Length, rightMatch.Length);
                        Console.WriteLine($"ticket \"{currentTicket}\" - {minMatch}{leftMatch[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
            }
        }
    }
}
