using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '\'', '\"', '\\', '/', '[', ']', ' ' };
            List <string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in input)
            {
                int lowerChars = 0;
                int upperChars = 0;
                foreach (var letter in word)
                {
                   
                    if (char.IsLower(letter))
                    {
                        lowerChars++;
                    }
                    if (char.IsUpper(letter))
                    {
                        upperChars++;
                    }

                }
                if (word.Length == lowerChars)
                {
                    lowerCase.Add(word);
                }
                else if ( word.Length == upperChars)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", " , lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", " , mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

        }
    }
}
