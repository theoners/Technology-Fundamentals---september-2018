using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var productQuantity = new Dictionary<string, int>();
            var productPrice = new Dictionary<string, double>();

            while (input[0]!="buy")
            {
                string product = input[0];
                double price =double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!productQuantity.ContainsKey(product))
                {
                    productQuantity.Add(product, quantity);
                    productPrice.Add(product, price);
                }
                else
                {
                    productPrice[product] = price;
                    productQuantity[product] += quantity;
                }

                input = Console.ReadLine().Split();
            }

            foreach (var product in productPrice)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value*productQuantity[product.Key]):F2}");
            }
        }
    }
}
