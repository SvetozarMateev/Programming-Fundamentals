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
            Dictionary<string, string> answer = new Dictionary<string,string>();
            List<string> input = new List<string>();
            
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
                    answer[input[i]] = "";
                }
                else
                {
                    if (input[i][input[i].Length - 2] == 'u' && input[i][input[i].Length - 1] == 'k' || input[i][input[i].Length - 1] == 's')
                    {

                    }
                    else
                        answer[input[i - 1]] = input[i];
                }
               
            }
            foreach (var pair in answer)
            {
                if (pair.Value != "")
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
