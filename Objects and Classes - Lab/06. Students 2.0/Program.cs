using System;
using System.Collections.Generic;

namespace _06._Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> studentList = new List<Student>();

            while (input != "end")
            {
                string[] line = input.Split();
                Student student = new Student()
                {
                    FirstName = line[0],
                    LastName = line[1],
                    Age = int.Parse(line[2]),
                    HomeTown = line[3]
                };

                if (StudentExist(studentList, student.FirstName, student.LastName, student.Age, student.HomeTown))
                {

                }
                else
                {
                    studentList.Add(student);
                }

                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (var student in studentList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static bool StudentExist(List<Student> studentList, string firstName, string lastName, int age, string town)
        {
            foreach (var student in studentList)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.Age = age;
                    student.HomeTown = town;
                    return true;
                }
            }
            return false;
        }
    }
}
