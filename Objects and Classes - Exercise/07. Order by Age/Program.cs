using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> personList = new List<Person>();

            while (input != "End")
            {
                string[] line = input.Split();
                string name = line[0];
                string id = line[1];
                int age = int.Parse(line[2]);

                Person person = new Person()
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                personList.Add(person);
                input = Console.ReadLine();
            }

            personList = personList.OrderBy(x => x.Age).ToList();

            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}