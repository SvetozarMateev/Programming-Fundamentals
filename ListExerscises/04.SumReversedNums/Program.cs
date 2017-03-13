using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int answer = 0;

            foreach (var num in input)
            {
                string stringedNum = num;
                char[] charedNum = stringedNum.Reverse().ToArray();
                string reversedNum = "";

                for (int i = 0; i < charedNum.Length; i++)
                {
                   reversedNum+= charedNum[i];
                }
                int number = int.Parse(reversedNum);
                answer += number;
            }
            Console.WriteLine(answer);
        }
    }
}

