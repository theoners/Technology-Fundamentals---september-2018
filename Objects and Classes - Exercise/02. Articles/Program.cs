using System;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleProperties = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article()
            {
                Title = articleProperties[0],
                Content = articleProperties[1],
                Author = articleProperties[2]
            };

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Edit")
                {
                    article.Content = input[1];
                }
                else if (input[0] == "ChangeAuthor")
                {
                    article.Author = input[1];
                }
                else if (input[0] == "Rename")
                {
                    article.Title = input[1];
                }
            }
            string result = article.Title + " - " + article.Content + ": " + article.Author;
            Console.WriteLine(result);
        }
    }
}