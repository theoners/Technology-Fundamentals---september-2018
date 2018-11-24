using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Familly
    {
        public List<Person> FamillyMembers { get; set; } = new List<Person>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());
            var familly = new Familly();
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine().Split();
                string memberName = line[0];
                int memberAge = int.Parse(line[1]);

                var person = new Person()
                {
                    Name = memberName,
                    Age = memberAge
                };

                
                familly.FamillyMembers.Add(person);
            }

            foreach (var members in familly.FamillyMembers.OrderByDescending(x=>x.Age))
            {
                Console.WriteLine(members.Name+" "+members.Age);
                break;
            }
        }
    }
}
