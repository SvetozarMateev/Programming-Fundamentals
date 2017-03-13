using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> answer = new Dictionary<string, string>();
            List<string[]> commands = new List<string[]>();
            while (true)
            {
                string[] commandRow = Console.ReadLine().Split(' ').ToArray();
                if (commandRow[0] == "END")
                    break;
                commands.Add(commandRow);
            }
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i][0] == "A")
                {
                    answer[commands[i][1]] = commands[i][2];
                }
                else if (commands[i][0] == "S")
                {
                    if (answer.ContainsKey(commands[i][1]))
                    {
                        foreach (var pair in answer)
                        {
                            if(pair.Key==commands[i][1])
                                Console.WriteLine($"{pair.Key} -> {pair.Value}");
                        }
                    }
                    else
                        Console.WriteLine($"Contact {commands[i][1]} does not exist.");
                }
                else if (commands[i][0] == "ListAll")
                {
                    foreach (var pair in answer.OrderBy(x=> x.Key))
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
            }
        }
    }
}
