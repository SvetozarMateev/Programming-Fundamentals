using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.ExtractSentenceByKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(new[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string reggex = ($"\\W{searchWord}\\W");
            Regex pattern = new Regex(reggex);
            for (int i = 0; i < sentences.Length; i++)
            {
                if (pattern.IsMatch(sentences[i]))
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
