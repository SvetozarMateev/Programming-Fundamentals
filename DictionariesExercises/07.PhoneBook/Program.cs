using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> commands = new List<string[]>();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                    break;
                else
                {
                    commands.Add(input);
                }
                 
            }
            for (int i = 0; i < commands.Count; i++)
            {
                if (commands[i][0] == "S")
                {
                    if (phoneBook.ContainsKey(commands[i][1]))
                    {
                        foreach (var pair in phoneBook)
                        {
                            if (pair.Key == commands[i][1])
                            {
                                Console.WriteLine($"{pair.Key} -> {pair.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[i][1]} does not exist.");
                    }
                }
                else if (commands[i][0] == "A")
                {                   
                        phoneBook[commands[i][1]] = commands[i][2];
                }
            }
        }
    }
}
