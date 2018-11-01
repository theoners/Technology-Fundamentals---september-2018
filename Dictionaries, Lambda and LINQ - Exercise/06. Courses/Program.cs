using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ");
            var courses = new Dictionary<string, List<string>>();

            while (input[0]!="end")
            {
                string courseName = input[0];
                string name = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(name);
                }
                else
                {
                    courses[courseName].Add(name);
                }

                input = Console.ReadLine().Split(" : ");
            }

             

            foreach (var course in courses.OrderByDescending(x=> x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var name in course.Value.OrderBy(w=> w))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
