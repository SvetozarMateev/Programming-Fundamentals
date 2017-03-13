using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            Regex regex = new Regex(@"<a.*?href.*?=(""|')(.*)\1>(.*?)<\/a>");

            while (text!="end")
            {
                string result = regex.Replace(text, @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(string.Join(" ", result));
                text = Console.ReadLine();

            }
            
           
        }
    }
}
