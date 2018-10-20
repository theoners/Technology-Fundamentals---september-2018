using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int productCount = int.Parse(Console.ReadLine());
            PrintOrder(product, productCount);
        }

        private static void PrintOrder(string product, int count)
        {
            double price = 0;
            switch (product)
            {
                case "water":
                    price = 1.0*count;
                    break;
                case "coffee":
                    price = 1.5*count;
                    break;
                case "coke":
                    price = 1.4*count;
                    break;
                case "snacks":
                    price = 2.0*count;
                    break;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
