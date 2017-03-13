using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<string> text = new List<string>();
            Dictionary<string, string> result = new Dictionary<string, string>();
            while (true)
            {
                input = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                if (input[0] == "stop")
                {
                    break;
                }
                text.Add(input[0]);
            }
            for (int i = 0; i < text.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(text[i], text[i + 1]);
                }
            }
            
            foreach (var pair in result)
            {
                char[] bug = new char[2];
                    bug = pair.Value.Skip(pair.Value.Length - 2).Take(2).ToArray();
                if (bug[0] != 'u' && bug[1] != 'k' | bug[1] !='s' )
                Console.WriteLine("{0} -> {1}" , pair.Key, pair.Value);
            }
        }
    }
}
