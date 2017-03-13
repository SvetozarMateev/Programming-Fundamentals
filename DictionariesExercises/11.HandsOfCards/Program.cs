using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> typesOfCards = new Dictionary<string, int>();
        typesOfCards.Add("2", 2);
        typesOfCards.Add("3", 3);
        typesOfCards.Add("4", 4);
        typesOfCards.Add("5", 5);
        typesOfCards.Add("6", 6);
        typesOfCards.Add("7", 7);
        typesOfCards.Add("9", 9);
        typesOfCards.Add("10", 10);
        typesOfCards.Add("8", 8);
        typesOfCards["S"] = 4;
        typesOfCards["H"] = 3;
        typesOfCards["D"] = 2;
        typesOfCards["C"] = 1;
        typesOfCards["J"] = 11;
        typesOfCards["Q"] = 12;
        typesOfCards["K"] = 13;
        typesOfCards["A"] = 14;
        char[] separators = new char[] { ' ', ':', ',' };
        Dictionary<string, List<string>> nameToCards = new Dictionary<string, List<string>>();
        List<List<string>> lines = new List<List<string>>();
        Dictionary<string, long> result = new Dictionary<string, long>();
        while (true)
        {
            List<string> line = Console.ReadLine().Split(':').ToList();
            if (line[0] == "JOKER")
                break;
            lines.Add(line);
        }
        for (int i = 0; i < lines.Count; i++)
        {
            if (nameToCards.ContainsKey(lines[i][0]) == false)
            {
                nameToCards[lines[i][0]] = new List<string>();
            }               
             nameToCards[lines[i][0]]=(lines[i][lines.Count-1].Split(separators, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList());
            
        }
        foreach (var pair in nameToCards)
        {
            result.Add(pair.Key,0);
            List<string> cards = new List<string>();
            for (int i = 0; i < pair.Value.Count; i++)
            {
                for (int a = 0; a < pair.Value[i].Length; a++)
                {
                    if (pair.Value[i][a] == '0')
                        cards.Add("10");                      
                    
                    else if(pair.Value[i][a]!='1')
                        cards.Add(pair.Value[i][a].ToString());
                }
            }
            for (int b = 1; b < cards.Count; b++)
            {                          
                  if (typesOfCards.ContainsKey(cards[b]) && typesOfCards.ContainsKey(cards[b-1] )&& b%2!=0)                  
                        result[pair.Key] += typesOfCards[cards[b]] * typesOfCards[cards[b-1]];  //mistake                               
            }
        }
        foreach (var couple in result)
        {
            Console.WriteLine($"{couple.Key}: {couple.Value}");
        }
    }
}

