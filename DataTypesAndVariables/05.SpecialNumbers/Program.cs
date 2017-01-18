using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int firstdigit = i / 10;
                int seconddigit = i % 10;
                if(firstdigit+seconddigit==11| firstdigit+seconddigit==5| firstdigit + seconddigit == 7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");

                }
            }

        }
    }
}
