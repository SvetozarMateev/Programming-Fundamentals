using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex pattern = new Regex(@"(?:\s)[a-zA-Z]+(\.|\-|_)?[a-zA-Z]+@[a-zA-Z]+\-*[a-zA-Z]*\.[a-zA-Z]+(\.[a-zA-Z]+){0,}");
            var answer = pattern.Matches(text);
            foreach (Match item in answer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
