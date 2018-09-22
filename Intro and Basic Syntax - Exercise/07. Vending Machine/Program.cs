using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            decimal totalMoney = 0;

            while (input!="start")
            {
                decimal coin = decimal.Parse(input);

                if (coin==0.1m || coin==0.2m || coin==0.5m || coin==1.0m || coin==2.0m)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                input = Console.ReadLine().ToLower();
            }

            string product = Console.ReadLine().ToLower();

            while (product!="end")
            {
                if (product=="nuts")
                {
                    if (totalMoney>=2.0m)
                    {
                        Console.WriteLine("Purchased nuts");
                        totalMoney -= 2.0m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (product == "water")
                {
                    if (totalMoney >= 0.7m)
                    {
                        Console.WriteLine("Purchased water");
                        totalMoney -= 0.7m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (product == "crisps")
                {
                    if (totalMoney >= 1.5m)
                    {
                        Console.WriteLine("Purchased crisps");
                        totalMoney -= 1.5m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (product == "soda")
                {
                    if (totalMoney >= 0.8m)
                    {
                        Console.WriteLine("Purchased soda");
                        totalMoney -= 0.8m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (product == "coke")
                {
                    if (totalMoney >= 1.0m)
                    {
                        Console.WriteLine("Purchased coke");
                        totalMoney -= 1.0m;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
