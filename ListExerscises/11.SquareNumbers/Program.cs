using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answer = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                double sqrtNum = Math.Sqrt(numbers[i]);
                int square =(int) Math.Sqrt(numbers[i]);
                if (sqrtNum == square)
                {
                    answer.Add(numbers[i]);
                }

            }
            answer = answer.OrderByDescending(num=>num).ToList();
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
