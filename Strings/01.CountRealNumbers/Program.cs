using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> result = new SortedDictionary<double, int>();
         

            foreach (var num in nums)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result[num] = 1;
                }
            }
            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1}" , pair.Key, pair.Value);
            }
           
        }
    }
}
