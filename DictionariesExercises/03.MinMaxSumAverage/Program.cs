using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int entry = int.Parse(Console.ReadLine());
                input.Add(entry);
            }
            int sum = input.Sum();
            int min = input.Min();
            int max = input.Max();
            double average = input.Average();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
