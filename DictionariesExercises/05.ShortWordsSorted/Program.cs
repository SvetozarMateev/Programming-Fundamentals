using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\'', '\"', '\\', '/', '!', '?', ' ' };
            List <string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> output = input.OrderBy(x => x).Select(x=>x.ToLower()).Where(x=>x.Length < 5).Distinct().ToList();
            Console.WriteLine(string.Join(", ", output));

        }
    }
}
