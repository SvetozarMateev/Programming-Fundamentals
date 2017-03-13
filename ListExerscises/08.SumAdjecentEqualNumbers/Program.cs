using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumAdjecentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);

                    if (i > 0)
                        i -= 2;
                    else
                        i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
