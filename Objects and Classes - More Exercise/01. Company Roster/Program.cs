using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine().Split();
                string name = line[0];
                double salary = double.Parse(line[1]);
                string department = line[2];

                Employee employee = new Employee(name,salary,department);

                if (!employees.ContainsKey(department))
                {
                    employees.Add(department,new List<Employee>());
                }
                
                    employees[department].Add(employee);
                
            }

            foreach (var employee in employees.OrderByDescending(x => x.Value.Average(y=>y.Salary)))
            {
                Console.WriteLine($"Highest Average Salary: {employee.Key}");

                foreach (var salary in employee.Value.OrderByDescending(x => x.Salary))
                {
                    Console.WriteLine($"{salary.Name} {salary.Salary:F2}");
                }
                break;
            }


        }
    }
}
