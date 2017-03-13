using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> answer = new List<int>();
        for (int mainIndex = 0; mainIndex < input.Count; mainIndex++)
        {
            List<int> result = new List<int>();
            result.Add(input[mainIndex]);
            for (int secondaryIndex = mainIndex; secondaryIndex < input.Count; secondaryIndex++)
            {
                bool smallest = true;
                int smallNums = 0;
                if (result[result.Count - 1] < input[secondaryIndex])
                {
                    for (int checkingIndex = secondaryIndex; checkingIndex < input.Count; checkingIndex++)
                    {
                        if (input[checkingIndex] < input[secondaryIndex] && input[checkingIndex] > result[result.Count - 1])
                        {
                            smallest = false;
                            smallNums++;
                        }

                    }
                    if (smallest)
                    {
                        result.Add(input[secondaryIndex]);
                    }
                    else if (smallNums == 1)
                    {
                        result.Add(input[secondaryIndex]);
                    }
                }
            }
            if (answer.Count < result.Count)
            {
                answer = new List<int>();
                answer.AddRange(result);
            }
        }
        Console.WriteLine(string.Join(" ", answer));
    }
}

