using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        SortedDictionary<double, int> answer = new SortedDictionary<double, int>();
        for (int i = 0; i < input.Count(); i++)
        {
            if (answer.ContainsKey(input[i]) == false)
                answer[input[i]] = 1;
            else
                answer[input[i]]++;

        }
        
        foreach (var pair in answer)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

