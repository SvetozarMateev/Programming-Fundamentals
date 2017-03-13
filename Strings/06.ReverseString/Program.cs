using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToList();
            text.Reverse();
            Console.WriteLine(string.Join("", text));
        }
    }
}
