using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<char> answer = new List<char>();
            for (int i = start; i <= end; i++)
            {
                char result = (char)i;
                answer.Add(result);
            }
            Console.WriteLine(string.Join(" ",answer));
        }
    }
}
