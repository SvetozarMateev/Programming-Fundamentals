using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> text = new List<string>();
            string[] words = new string[3];
            List<string[]> allWords = new List<string[]>();
            SortedDictionary<string,List<string>> result = new SortedDictionary<string, List<string>>();
            Dictionary<string, int> numsResult = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                 words = Console.ReadLine().Split(' ').ToArray();
                allWords.Add(words);
                
            }
            for (int i = 0; i < allWords.Count; i++)
            {
                List<string> IPS = new List<string>();
                string IP = allWords[i][0];
                string name = allWords[i][1];
                int num = int.Parse(allWords[i][2]);
                IPS.Add(IP);
                if (result.ContainsKey(name) == false)
                {
                    result.Add(name, IPS);
                }
                else
                {
                    if(result[name].Contains(IPS[0])==false)
                    result[name].AddRange(IPS);
                }
                if(numsResult.ContainsKey(name)== false)
                {
                    numsResult.Add(name, num);
                }
                else
                {
                    numsResult[name] += num;
                }
            }
            foreach (var pair in result)
            {
                pair.Value.Sort();
               
                
            }
            foreach (var pair in result)
            {
                foreach (var item in numsResult)
                {
                    if (pair.Key == item.Key)
                    {
                        string needed = string.Join(", ", pair.Value);
                        Console.WriteLine("{0}: {1} [{2}]", pair.Key, item.Value, needed);
                    }
                   
                }
            }
        }
    }
}
