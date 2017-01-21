using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPart = "Hello";
            string secondPart = "World";
            object result = firstPart +" "+ secondPart;
            string answer = (string)result;
            Console.WriteLine(answer);
        }
    }
}
