using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            List<int> distinctInput = input.Distinct().ToList();
            distinctInput= distinctInput.OrderBy(x=>x).ToList();
            
            for (int i = 0; i < distinctInput.Count; i++)
            {
                int count = 0;
                for (int a = 0; a < input.Count; a++)
                {
                    if (distinctInput[i] == input[a])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{distinctInput[i]} -> {count}");
            }
        }
    }
}
