using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int length = 1;
            int maxLength = -100;
            string num = "";
            for (int i = 1; i < input.Count ; i++)
            {
                if (input[i] == input[i - 1])
                {
                    length++;
                }
                else
                {
                    if (maxLength < length)
                    {
                        maxLength = length;
                        num = input[i - 1];
                    }
                    length = 1;
                }
            }
            if(maxLength < length)
            {
                maxLength = length;
                num = input[input.Count - 1];
            }
            length = 1;
            List<string> answer = new List<string>();
            for (int i = 0; i < maxLength; i++)
            {
                answer.Add(num);
            }
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
