using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input= Console.ReadLine().ToCharArray();
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                uint num = input[i];
                string stringedNum = num.ToString("X");
                string result = $"\\u{stringedNum.PadLeft(4,'0').ToString().ToLower()}";
                answer.Append(result);


            }
            Console.WriteLine(answer.ToString());
        }
    }
}
