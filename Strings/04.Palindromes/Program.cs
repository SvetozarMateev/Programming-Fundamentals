using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new[] { ' ', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> answer = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i].Length % 2 == 0)
                {
                    string firstpart = text[i].Substring(0, text[i].Length / 2);
                    string semiDoneSecondPart = text[i].Substring(text[i].Length / 2);
                    char[]DoneSecondPart = semiDoneSecondPart.Reverse().ToArray();
                    string secondPart = string.Join("", DoneSecondPart);
                    int num = string.Compare(firstpart, secondPart);
                    if (num == 0)
                        answer.Add(text[i]);
                }
                else
                {
                    string firstpart = text[i].Substring(0, text[i].Length / 2);
                    string semiDoneSecondPart = text[i].Substring(text[i].Length / 2+1);
                    char[] DoneSecondPart = semiDoneSecondPart.Reverse().ToArray();
                    string secondPart = string.Join("", DoneSecondPart);
                    int num = string.Compare(firstpart, secondPart);
                    if (num == 0)
                        answer.Add(text[i]);
                }
                
               
            }
            answer = answer.Distinct().ToList();
            answer.Sort();
            Console.WriteLine(string.Join(", ",answer));

        }
    }
}
