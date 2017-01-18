using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool special = false;
            for (int i = 1; i <= n; i++)
            {
                int number = i;

                int sum = 0;

                while (number > 0)
                {
                    sum += i % 10;
                    number = i / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {special}");
                sum = 0;
                
            }

        }
    }
}
