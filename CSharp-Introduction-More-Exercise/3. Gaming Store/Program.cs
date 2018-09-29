using System;

namespace _3._Gaming_Store
{
    class Program
    {
        static void Main()
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            decimal gamePrice = 0m;
            decimal totalSpent = 0m;

            while(input !="Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99m;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99m;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99m;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99m;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99m;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99m;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (gamePrice<=balance && gamePrice!=0)
                {
                    Console.WriteLine($"Bought {input}");
                    totalSpent += gamePrice;
                    if (totalSpent==balance)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if(gamePrice!=0)
                {
                    Console.WriteLine("Too Expensive");
                }
                gamePrice = 0m;
                input = Console.ReadLine();
            }
            if (balance!=totalSpent)
            {
                Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${balance - totalSpent}");
            }
            

        }
    }
}
