using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[]output=input.Reverse().ToArray();
            Console.WriteLine(string.Join("",output));
        }
    }
}
