using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            Dictionary<string, int> answer = new Dictionary<string, int>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                    break;
                input.Add(command);
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if(answer.ContainsKey(input[i]) == false)
                        answer[input[i]] = 0;
                }                   
                else
                    answer[input[i - 1]] += int.Parse(input[i]);
            }
            foreach (var pair in answer)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
