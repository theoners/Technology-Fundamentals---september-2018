using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            var resourceQuantity = new Dictionary<string, int>();
            while (true)
            {
                if (resource=="stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity.Add(resource, quantity);
                }
                else
                {
                    resourceQuantity[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var kvp in resourceQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
