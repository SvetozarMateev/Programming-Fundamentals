using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PhoneBookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<string> input = new List<string>();
            Dictionary<string, string> result = new Dictionary<string, string>();
            SortedDictionary<string, string> answer = new SortedDictionary<string, string>();
            while (true)
            {
                lines = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                if (lines.Contains("END"))
                {
                    break;
                }
                input.Add(lines[0]);

            }
            foreach (var part in input)
            {
                List<string> line = part.Split(' ').ToList();
                if (line[0] == "A")
                {
                    if (result.ContainsKey(line[1]))
                        result[line[1]] = line[2];
                    else
                    {
                        result.Add(line[1], line[2]);
                    }

                }
                else if (line[0] == "S")

                {
                    if (answer.ContainsKey(line[1]) == false && result.ContainsKey(line[1]) == false)
                    {
                        answer.Add(line[1], $"Contact {line[1]} does not exist.");
                    }
                    else if (result.ContainsKey(line[1]) && answer.ContainsKey(line[1]) == false)
                    {
                        foreach (var pair in result)
                        {
                            if (pair.Key == line[1])
                            {
                                answer.Add(pair.Key, pair.Value);
                            }
                        }
                    }
                }
                else if (line[0] == "ListAll")
                {
                    foreach (var pair in result)
                    {
                        if (answer.ContainsKey(pair.Key)== false)
                        {
                            answer.Add(pair.Key, pair.Value);
                        }
                        
                    }
                }

            }
            
            foreach (var pair in answer)
            {
                if (pair.Value != $"Contact {pair.Key} does not exist.")
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
                else
                {
                    Console.WriteLine(pair.Value);
                }
            }
        }
    }
}
