using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string checker = Console.ReadLine();
            int counter = 0;
            int index = 0;
            while (true)
            {
                if (text.IndexOf(checker,index) > -1)
                {
                    index = text.IndexOf(checker, index)+1;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
