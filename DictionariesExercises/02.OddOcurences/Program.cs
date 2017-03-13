using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOcurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> answer = new Dictionary<string, int>();
            List<string> result = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                string thing = input[i].ToLower();
                if (answer.ContainsKey(thing) == false)
                {
                    answer[thing] = 1;
                }
                else
                {
                    answer[thing]++;
                }
            }
            foreach (var pair in answer)
            {
                if (pair.Value % 2 != 0)
                {
                  
                        result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
