using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<string[]> allCommands = new List<string[]>();
            while (true)
            {                
                string[] command= Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "print")
                    break;
                allCommands.Add(command);
            }
            for (int i = 0; i < allCommands.Count; i++)
            {
                if (allCommands[i][0] == "add")
                {
                    int index = int.Parse(allCommands[i][1]);
                    int num = int.Parse(allCommands[i][2]);
                    input.Insert(index, num);
                }
                else if (allCommands[i][0] == "addMany")
                {
                    int index = int.Parse(allCommands[i][1]);
                    List<int> nums = new List<int>();
                    for (int a = 2; a < allCommands[i].Length; a++)
                    {
                        nums.Add(int.Parse(allCommands[i][a]));
                    }
                    input.InsertRange(index, nums);
                }
                else if (allCommands[i][0] == "contains")
                {
                    int element = int.Parse(allCommands[i][1]);
                    bool answer = input.Contains(element);
                    if (answer)
                    {
                        int index = input.IndexOf(element);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if(allCommands[i][0] == "remove")
                {
                    input.RemoveAt(int.Parse(allCommands[i][1]));
                }
                else if (allCommands[i][0] == "shift")
                {
                    List<int> numbers = input;
                    int count =int.Parse( allCommands[i][1]);
                    for (int b = 0; b < count; b++)
                    {                      
                            input.Insert(numbers.Count, input[0]);
                            input.RemoveAt(0);                      
                    }                 
                }
                else if (allCommands[i][0] == "sumPairs")
                {
                    int count = input.Count;
                    List<int> answer = new List<int>();
                    if (input.Count % 2 == 0)
                    {
                        for (int z = 0; z < count - 1; z += 2)
                        {
                            answer.Add(input[z] + input[z + 1]);
                        }
                    }
                    else
                    {
                        for (int z = 0; z < count - 2; z += 2)
                        {
                            answer.Add(input[z] + input[z + 1]);
                        }
                        answer.Add(input[input.Count - 1]);
                    }
                        
                    input = answer;
                   
                }
            }
            Console.WriteLine("[{0}]",string.Join(", ", input));
        }
    }
}
