using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        
        List<string> input = new List<string>();
        List<string> text = new List<string>();
        List<string[]> allWords = new List<string[]>();
        string[] words = new string[3];
        SortedDictionary<string, Dictionary<string, int>> result = new SortedDictionary<string, Dictionary<string, int>>();
        Dictionary<string, string> outter = new Dictionary<string, string>();
        
        
        
        while (true)
        {
            input = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            if (input[0] == "end")
            {
                break;
            }
            text.AddRange(input);
        }
        for (int i = 0; i < text.Count; i++)
        {
            words = text[i].Split(' ').ToArray();
            allWords.Add(words);
        }
        for (int i = 0; i < allWords.Count; i++)
        {
            Dictionary<string, int> inner = new Dictionary<string, int>();
            string IP = allWords[i][0].Substring(allWords[i][0].IndexOf('=') + 1);
            string message = allWords[i][1].Substring(allWords[i][1].IndexOf('=') + 1);
            string user = allWords[i][2].Substring(allWords[i][2].IndexOf('=') + 1);
            if (inner.ContainsKey(IP) == false)
            {
                inner.Add(IP, 1);
            }
            else
            {
                
            }
            if (result.ContainsKey(user) == false)
            {
                result.Add(user, inner);
                
            }
            else
            {
                if (result[user].ContainsKey(IP))
                {
                    result[user][IP]++;
                }
                else
                {
                    result[user].Add(IP,1);
                }
            }
          }
        foreach (var pair in result)
        {
            Console.WriteLine("{0}: ", pair.Key);
            int i = 0;
            foreach(var p in pair.Value)
            {
                if(pair.Value.Count>1==false)
                    Console.WriteLine("{0} => {1}.", p.Key, p.Value);
                else
                {
                    List<string> answer = new List<string>();
                    foreach(var g in pair.Value)
                    {
                        answer.Add($"{g.Key} => {g.Value}");
                    }
                    if(i==0)
                        Console.WriteLine(string.Join(", ", answer)+'.');
                    i++;
                }
            }
            
        }
        }
    }


