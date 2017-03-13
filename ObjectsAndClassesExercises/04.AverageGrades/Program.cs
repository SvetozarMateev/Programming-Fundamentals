using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades {
            get
            {
                return Grades.Average();
            }
                }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<string>> students = new List<List<string>>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                students.Add(input);
            }
            List<Student> answer = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                Student somenone = new Student();
                somenone.Name = students[i][0];
                List<double> grades = students[i].Skip(1).Select(double.Parse).ToList();
                somenone.Grades = grades;
                
                    answer.Add(somenone);
               
            }
            answer = answer.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades).ToList();
            for (int i = 0; i < answer.Count; i++)
            {
                if(answer[i].AverageGrades>=5)
                    Console.WriteLine($"{answer[i].Name} -> {answer[i].AverageGrades:f2}");
            }
        }
    }
}
