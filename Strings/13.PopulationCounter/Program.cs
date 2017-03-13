using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<string> text = new List<string>();
            List<string[]> allWords = new List<string[]>();
            Dictionary<string, SortedDictionary<string, long>> result = new Dictionary<string, SortedDictionary<string, long>>();
            Dictionary<string, long> sortedResult = new Dictionary<string,long>();
            string[] words = new string[3];
            while (true)
            {
                input = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                if (input[0] == "report")
                {
                    break;
                }
                text.AddRange(input);

            }
            for (int i = 0; i < text.Count; i++)
            {
                words = text[i].Split('|').ToArray();
                allWords.Add(words);
            }
            for (int i = 0; i < allWords.Count; i++)
            {
                SortedDictionary<string, long> secondInner = new SortedDictionary<string, long>();
                string country = allWords[i][1];
                string town = allWords[i][0];
                long population = long.Parse(allWords[i][2]);
                if (secondInner.ContainsKey(town) == false)
                {
                    secondInner.Add(town, population);
                }
                else
                {
                    secondInner[town] += population;
                }
                if (result.ContainsKey(country) == false)
                {

                    result.Add(country, secondInner);

                }
                else
                {
                    result[country].Add(town, population);
                }
            }
            foreach (var pair in result)
            {
                long sum = 0;
                foreach (var a in pair.Value.OrderByDescending(a => a.Value))
                {
                    sum += a.Value;
                }
                sortedResult.Add(pair.Key, sum);              
            }
            foreach (var pair in sortedResult.OrderByDescending(pair=>pair.Value))
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value);
                foreach (var r in result)
                {
                    if(r.Key==pair.Key)
                        foreach (var couple in r.Value.OrderByDescending(couple=>couple.Value))
                        {
                            Console.WriteLine("=>{0}: {1}", couple.Key, couple.Value);
                        }               
                }
            }
        }
    }
}
