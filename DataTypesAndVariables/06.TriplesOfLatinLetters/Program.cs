using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a'+n; i++)
            {
                for (char a = 'a'; a < 'a'+n; a++)
                {
                    for (char b = 'a'; b < 'a'+n; b++)
                    {
                        char[] word = new char[3];
                        word[0] = i;
                        word[1] = a;
                        word[2] = b;
                        Console.WriteLine(string.Join("",word));
                    }
                }
            }
        }
    }
}
