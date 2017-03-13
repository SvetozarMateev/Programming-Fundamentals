using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstinput = Console.ReadLine();
            string secondinput = Console.ReadLine();
            int length = Math.Max(firstinput.Length, secondinput.Length);
            string firstNum = firstinput.PadLeft(length, '0');
            string secondNum = secondinput.PadLeft(length, '0');

            StringBuilder answer = new StringBuilder();

            int excess = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int number = int.Parse(firstNum[i].ToString());
                int secondNumber = int.Parse(secondNum[i].ToString());
                int sum = number + secondNumber + excess;
                if (excess > 0)
                {
                    excess = 0;
                }
                if (sum >= 10)
                {
                    sum -= 10;
                    excess += 1;
                }
                answer.Append(sum.ToString());
            }
            if (excess > 0)
            {
                answer.Append(excess);
            }
            char[] arr = answer.ToString().ToCharArray();
            arr = arr.Reverse().ToArray();
            List<char> checker = arr.ToList();
            List<char> checkedAnswer = new List<char>();
            bool zero = false;
            for (int i = 0; i < checker.Count; i++)
            {
                if (checker[i] != '0')
                {
                    zero = true;

                }
                if (zero)
                {
                    checkedAnswer.Add(checker[i]);
                }
            }
            checker = checker.Distinct().ToList();

            if (checker[0] == 0 && checker.Count == 1)
            {
                Console.WriteLine('0');
            }
           
            else
            {
                string output = string.Join("", checkedAnswer);
                Console.WriteLine(output);
            }
            
        }
    }
}
