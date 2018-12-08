using System;
using System.Text.RegularExpressions;

namespace _07._HTML_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex titleRegex = new Regex(@"<title>(.*?)<\/title>");
            Regex secondTitleRegex = new Regex(@">(\\[a-z])?([A-Za-z].*?)<");
            Regex bodyRegex = new Regex(@"<body>.+<\/body>");
            Regex contentRegex = new Regex(@">(\\[a-z])?([A-Za-z].*?)<");
            var titleMatch = titleRegex.Match(input).ToString();
            var titles = secondTitleRegex.Matches(titleMatch);
            string title = "";
            foreach (Match match in titles)
            {
                if (match.Groups[2].Value.Contains("\\n"))
                {
                    var text = match.Groups[2].Value.Replace("\\n", " ");
                    text = text.Trim();
                    title += text + " ";
                }
                else
                {
                    title += match.Groups[2] + " ";
                }
               
            }

            title = title.Trim();
            var bodyMatch = bodyRegex.Match(input).ToString();
            var contentMatches = contentRegex.Matches(bodyMatch);
            string content = "";
            foreach (Match match in contentMatches)
            {
                    if (match.Groups[2].Value.Contains("\\n"))
                    {
                        var text = match.Groups[2].Value.Replace("\\n", " ");
                        text = text.Trim();
                        content += text + " ";
                    }
                    else
                    {
                        content += match.Groups[2] + " ";
                    }
            }
            content = content.Trim();
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Content: {content}");
        }
    }
}
