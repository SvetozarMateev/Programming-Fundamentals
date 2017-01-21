using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                bool prime = true;
                for (int a = 2; a <= Math.Sqrt(i); a++)
                {
                    if (i % a == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(i>1)
                    Console.WriteLine($"{i} -> {prime}");
            }

        }
    }
}
