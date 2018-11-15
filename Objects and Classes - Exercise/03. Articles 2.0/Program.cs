using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
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
            int lineNumner = int.Parse(Console.ReadLine());
            List<Article> listOfArticle = new List<Article>();

            for (int i = 0; i < lineNumner; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                var article = new Article()
                {
                    Title = input[0],
                    Content = input[1],
                    Author = input[2],
                };

                listOfArticle.Add(article);
            }

            string sortBy = Console.ReadLine();

            if (sortBy == "title")
            {
                listOfArticle = listOfArticle.OrderBy(x => x.Title).ToList();
            }
            else if (sortBy == "content")
            {
                listOfArticle = listOfArticle.OrderBy(x => x.Content).ToList();
            }
            else
            {
                listOfArticle = listOfArticle.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in listOfArticle)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}