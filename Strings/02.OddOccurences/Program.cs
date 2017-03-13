using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> result = new Dictionary<string, int>();
            List<string> answer = new List<string>();


            foreach(var word in text)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            foreach(var pair in result)
            {
                if(pair.Value%2 != 0)
                {
                    answer.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", " , answer));

        }
    }
}
