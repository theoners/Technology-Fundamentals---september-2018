using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    public class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> BagOfProduct { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,List<Person>> peopleList = new Dictionary<string, List<Person>>();
            var peopleAndMoney = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < peopleAndMoney.Length; i++)
            {
                string name = peopleAndMoney[i].Split('=')[0];
                double money =double.Parse(peopleAndMoney[i].Split('=')[1]);

                Person person = new Person()
                {
                    Name = name,
                    Money = money,
                    BagOfProduct = new List<string>()
                };
                peopleList.Add(name,new List<Person>());
                peopleList[name].Add(person);
            }
            var productAndCost = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,List<Product>> products = new Dictionary<string, List<Product>>();
            for (int i = 0; i < productAndCost.Length; i++)
            {
                string productName = productAndCost[i].Split('=')[0];
                double productCost =double.Parse( productAndCost[i].Split('=')[1]);

                Product product = new Product()
                {
                    Name=productName,
                    Cost=productCost
                };

                products.Add(productName,new List<Product>());
                products[productName].Add(product);
            }

            while (true)
            {
                var line = Console.ReadLine().Split();
                if (line[0]=="END")
                {
                    break;
                }

                string personName = line[0];
                string productName = line[1];

                Person currentPerson = peopleList[personName][0];
                Product currentProduct = products[productName][0];
                double currentPersonMoney = currentPerson.Money;
                double currentProductCost = currentProduct.Cost;

                if (currentProductCost<=currentPersonMoney)
                {
                    Console.WriteLine($"{currentPerson.Name} bought {productName}");
                    currentPerson.Money -= currentProductCost;
                    currentPerson.BagOfProduct.Add(productName);
                    peopleList[personName][0] = currentPerson;
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {productName}");
                }
            }

            foreach (var people in peopleList.Values)
            {
                foreach (var person in people)
                {
                 
                    Console.Write($"{person.Name} - ");
                    if (person.BagOfProduct.Count!=0)
                    {
                        Console.WriteLine($"{ string.Join(", ", person.BagOfProduct)}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing bought");
                    }
                }
            }
        }
    }
}
