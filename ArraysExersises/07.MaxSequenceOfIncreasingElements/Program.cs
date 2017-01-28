using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestStart = 0;
            int bestLen = -1;
            int len = 1;
            int start = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    len++;
                    if (len == 2)
                        start = i;
                }
                else
                {
                    if (bestLen < len)
                    {
                        bestLen = len;
                        bestStart = start;

                    }
                    len = 1;
                    start = 0;

                }
            }
            if (bestLen < len)
            {
                bestLen = len;
                bestStart = start;

            }
            len = 1;
            start = 0;
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
