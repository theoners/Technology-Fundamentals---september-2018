using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfmessage = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = { "Now I feel good.",
                                "I have succeeded with this product.",
                                "Makes miracles. I am happy of the results!",
                                "I cannot believe but now I feel awesome.",
                                "Try it yourself, I am very satisfied.",
                                "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            for (int i = 0; i < numberOfmessage; i++)
            {
                Console.WriteLine($"{phrases[random.Next(0, 5)]} " +
                    $"{events[random.Next(0, 5)]} " +
                    $"{authors[random.Next(0, 7)]} – " +
                    $"{cities[random.Next(0, 4)]}.");
            }
        }
    }
}
