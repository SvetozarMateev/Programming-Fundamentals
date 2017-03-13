using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.UsernameValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Regex pattern = new Regex(@"(?:(\s+?|\\+?|\/+?|\(+?|\)+?|^))([a-zA-z]\w{2,24})");
            List<string> answers = new List<string>();
            for (int i = 0; i < usernames.Length; i++)
            {
                if (pattern.IsMatch(usernames[i]) && usernames[i].Length >= 3 && usernames[i].Length <= 25)
                {
                    answers.Add(usernames[i]);
                }
            }
            int biggestSum = 0;
            List<string> biggestTwo = new List<string>() { "",""};
            for (int i = 0; i < answers.Count-1; i++)
            {
                if (answers[i].Length + answers[i + 1].Length > biggestSum)
                {
                    biggestSum = answers[i].Length + answers[i + 1].Length;
                    biggestTwo[0] = answers[i];
                    biggestTwo[1] = answers[i + 1];
                }
            }
            for (int i = 0; i < biggestTwo.Count; i++)
            {
                Console.WriteLine(biggestTwo[i]);
            }
        }
    }
}
