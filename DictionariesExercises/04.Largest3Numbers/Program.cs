using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            input = input.OrderByDescending(x => x).ToList();
            List<double> answer = input.Take(3).ToList();
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
