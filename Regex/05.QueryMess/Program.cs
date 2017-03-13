using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex urlPattern = new Regex(@"(\w+)=(https:\/\/.+)&");

            List<string> sentences = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;

                sentences.Add(input+"&");
            }
            Regex doubleSpacePattern = new Regex(@"(%20|\+){2,}");
            Regex spacePattern = new Regex(@"(%20|\+)");
            Regex pattern = new Regex(@"(.*?)=(.*?)&");
            for (int i = 0; i < sentences.Count; i++)
            {
                sentences[i] = doubleSpacePattern.Replace(sentences[i], " ");
                sentences[i]=spacePattern.Replace(sentences[i], " ");
                //Console.WriteLine(sentences[i]);
                if (urlPattern.IsMatch(sentences[i]))
                {
                    var matches = urlPattern.Matches(sentences[i]);
                    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

                    foreach (Match item in matches)
                    {
                        if (result.ContainsKey(item.Groups[1].ToString()) == false)
                            result[item.Groups[1].ToString()] = new List<string>();
                        result[item.Groups[1].ToString()].Add(item.Groups[2].ToString());
                    }
                    foreach (var pair in result)
                    {
                        Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                    }
                    Console.WriteLine();

                }
                else
                {
                    var matches = pattern.Matches(sentences[i]);
                    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

                    foreach (Match item in matches)
                    {
                        if (result.ContainsKey(item.Groups[1].ToString()) == false)
                            result[item.Groups[1].ToString()] = new List<string>();
                        result[item.Groups[1].ToString()].Add(item.Groups[2].ToString());
                    }
                    foreach (var pair in result)
                    {
                        Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                    }
                    Console.WriteLine();
                }                              
            }
        }
    }
}
