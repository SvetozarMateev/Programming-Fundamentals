using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++)
            {
                int numberOfLetter = letters[i];

                Console.WriteLine($"{letters[i]} -> {numberOfLetter-97}");
            }
        }
    }
}
