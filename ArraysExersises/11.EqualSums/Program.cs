using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        bool sums = false;
        for (int i = 1; i < numbers.Length; i++)
        {
            long firstSum = 0;
            long secondSum = 0;
            for (int a = 0; a < i - 1; a++)
            {
                firstSum += numbers[a];
            }
            for (int b = i; b < numbers.Length; b++)
            {
                secondSum += numbers[b];
            }
            if (firstSum == secondSum)
            {
                sums = true;
                Console.WriteLine(i - 1);
                break;
            }
        }
        if (!sums && numbers.Length > 1)
        {
            Console.WriteLine("no");
        }
        if (!sums && numbers.Length <= 1)
        {
            Console.WriteLine("0");
        }
    }
}

