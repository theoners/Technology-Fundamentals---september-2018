using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceBox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxList = new List<Box>();

            while (input != "end")
            {
                string[] line = input.Split();
                string serialNumber = line[0];
                string itemName = line[1];
                int itemQuantity = int.Parse(line[2]);
                decimal itemPrice = decimal.Parse(line[3]);

                Box box = new Box();
                box.Item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PriceBox = box.Item.Price * box.ItemQuantity;

                boxList.Add(box);

                input = Console.ReadLine();

            }

            List<Box> result = boxList.OrderByDescending(x => x.PriceBox).ToList();

            foreach (var box in result)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${(box.Item.Price):F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
}
