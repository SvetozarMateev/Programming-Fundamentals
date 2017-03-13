using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            foreach (var ban in bannedWords)
            {
               text= text.Replace(ban, new string('*', ban.Length));
            }
            Console.WriteLine(text);
        }
    }
}
