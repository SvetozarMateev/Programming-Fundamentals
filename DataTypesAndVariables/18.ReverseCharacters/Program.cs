using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            char[] result = new char[3];
            result[0] = firstChar;
            result[1] = secondChar;
            result[2] = thirdChar;
            result = result.Reverse().ToArray();
            Console.WriteLine(string.Join("",result));

        }
    }
}
