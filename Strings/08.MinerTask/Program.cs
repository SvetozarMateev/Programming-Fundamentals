using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<string> result = new List<string>();
            Dictionary<string, int> answer = new Dictionary<string, int>();
            while (true)
            {
                input = Console.ReadLine().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                if (input[0] == "stop")
                {
                    break;
                }
                result.Add(input[0]);
                
            }
            
            for (int i = 0; i < result.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(result[i + 1]);
                    if (answer.ContainsKey(result[i]) == false)
                        answer.Add(result[i], num);
                    else
                    {
                        answer[result[i]] += num;
                    }
                }
            }
            foreach (var pair in answer)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
           
        }
    }
}
