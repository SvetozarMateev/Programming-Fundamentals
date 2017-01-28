using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] distinctNumbers = input.Distinct().ToArray();
            int counter = 0;
            int bestLength = -1;
            string answer = "";
            foreach (var num in distinctNumbers)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == num)
                    {
                        counter++;
                    }
                }
                if (counter > bestLength)
                {
                    bestLength = counter;
                    answer = num;
                }
                counter = 0;
            }
            Console.WriteLine( answer);
        }
    }
}
