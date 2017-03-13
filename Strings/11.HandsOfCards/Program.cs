using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        char[] separators = new char[] { ',', ':' };
        List<string> input = new List<string>();
        List<string> text = new List<string>();
        Dictionary<char, int> cardvalues = new Dictionary<char, int>();
        cardvalues.Add('2', 2);
        cardvalues.Add('3', 3);
        cardvalues.Add('4', 4);
        cardvalues.Add('5', 5);
        cardvalues.Add('6', 6);
        cardvalues.Add('7', 7);
        cardvalues.Add('8', 8);
        cardvalues.Add('9', 9);
        cardvalues.Add('J', 11);
        cardvalues.Add('Q', 12);
        cardvalues.Add('K', 13);
        cardvalues.Add('A', 14);
        cardvalues.Add('S', 4);
        cardvalues.Add('H', 3);
        cardvalues.Add('D', 2);
        cardvalues.Add('C', 1);
        List<string> words = new List<string>();
        Dictionary<string, List<string>> preResult = new Dictionary<string, List<string>>();
        Dictionary<string, int> result = new Dictionary<string, int>();
        Dictionary<string, List<string>> midRes = new Dictionary<string, List<string>>();
        List<string>names = new List<string>();
        while (true)
        {
            input = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            if (input[0] == "JOKER")
            {
                break;
            }
            text.Add(input[0]);
        }
        int c = 0;       
        foreach (var line in text)
        {
            words = line.Split(separators, StringSplitOptions.None).ToList();
            List<string> cards = words.Skip(1).Distinct().ToList();
            if (midRes.ContainsKey(words[0]) == false)
            {
                midRes.Add(words[0], cards);
            }
            else
            {
                midRes[words[0]].AddRange(cards);
            }        
                names.Add(words[0]);        
            c++;
        }
        names = names.Distinct().ToList();
        foreach (var name in names)
        {
            result.Add(name, 0);
        }
        int i = 0;
        foreach (var value in midRes.Values.Distinct())
        {           
            List<string> cad = value.Distinct().ToList();
            List<int> cardInt = new List<int>();
            for (int a = 0; a < cad.Count; a++)
            {
                if (cardvalues.ContainsKey(cad[a][1]) && cad[a][1] != '1')
                {
                    if (cardvalues.ContainsKey(cad[a][2]))
                    {
                        cardInt.Add(cardvalues[cad[a][1]] * cardvalues[cad[a][2]]);
                    }
                }
                else if (cad[a][1] == '1')
                {
                    if (cardvalues.ContainsKey(cad[a][3]))
                    {
                        cardInt.Add(10 * cardvalues[cad[a][3]]);
                    }
                }
                var sum = cardInt.Sum();
                if (result.ContainsKey(names[i]) == false)
                {
                    result.Add(names[i], sum);              
                }
                else
                {
                    result[names[i]] = sum;                
                }
            }
            i++;           
        }
        foreach (var pair in result)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}


