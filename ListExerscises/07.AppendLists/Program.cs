using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '|' };
            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> output = new List<string>();

            for (int i = input.Count-1; i >=0; i--)
            {
                input[i].Trim();
                    output.Add(input[i]);
                
            }
            
            Console.WriteLine(string.Join(" ", output));
            

        }
    }
}
