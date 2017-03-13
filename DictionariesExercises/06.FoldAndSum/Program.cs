using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> firstK = new List<int>();
            List<int> midK = new List<int>();
            List<int> lastK = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i < input.Count / 4)
                    firstK.Add(input[i]);
                else if (i >= input.Count / 4 && i < input.Count * 3 / 4)
                    midK.Add(input[i]);
                else
                    lastK.Add(input[i]);
            }
            firstK.Reverse();
            lastK.Reverse();
            List<int> mergedFirstAndLast = firstK.Concat(lastK).ToList();
            for (int i = 0; i < midK.Count; i++)
            {
                mergedFirstAndLast[i] += midK[i];
            }
            Console.WriteLine(string.Join(" ", mergedFirstAndLast));
        }
    }
}
