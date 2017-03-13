using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var largest3 = nums.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" " , largest3));
        }
    }
}
