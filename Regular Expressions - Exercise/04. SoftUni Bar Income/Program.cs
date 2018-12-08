using System;
using System.Text.RegularExpressions;

namespace _04._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input=="end of shift")
                {
                    break;
                }

                Regex regex = new Regex(@"([%][A-Z]{1}[a-z]*[%]).*?([<]\w+[>]).*?([|][0-9]+[|]).*?([0-9]+(\.[0-9]+)?)\$");

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string name = match.Groups[1].ToString();
                    name = name.Substring(1, name.Length - 2);
                    string product = match.Groups[2].ToString();
                    product = product.Substring(1, product.Length - 2);
                    string quantityAsText = match.Groups[3].ToString();
                    double quantity = double.Parse(quantityAsText.Substring(1, quantityAsText.Length - 2));
                    string priceAsText = match.Groups[4].ToString();
                    double price = double.Parse(priceAsText);
                    totalIncome += quantity * price;

                    Console.WriteLine($"{name}: {product} - {(quantity*price):F2}");
                }


            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
