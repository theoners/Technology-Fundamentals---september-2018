using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, List<double>>();


            for (int i = 0; i < number; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades.Add(studentName, new List<double>());
                    
                }
                
                    studentsGrades[studentName].Add(grade);
            }
            var result = studentsGrades.Where(x=> x.Value.Average()>=4.5).OrderByDescending(x => x.Value.Average());

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value.Average()):F2}");
            }
        }
    }
}
